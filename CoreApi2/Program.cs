using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<BookContext>(opt => opt.UseInMemoryDatabase("BookList"));

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();




app.MapGet("/hello", () => "hello world");

app.MapGet("/bookitems", async (BookContext db) => await db.Books.ToListAsync());

app.MapPost("/bookitems", async (Book bk, BookContext db) =>
{
    db.Books.Add(bk);
    await db.SaveChangesAsync();
    return Results.Created($"/bookitems/{bk.BookId}",bk);
});

app.MapPut("/bookitems/{id}", async (int id, Book bk, BookContext db) =>
{
    var fi = await db.Books.FindAsync(id);
    if (fi is null)
        return Results.NotFound();
    fi.BookName = bk.BookName;
    fi.Author = bk.Author;
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/bookitems/{id}", async (int id, BookContext db) =>
{
    if(await db.Books.FindAsync(id) is Book bk)
    {
        db.Books.Remove(bk);
        await db.SaveChangesAsync();
        return Results.Ok(bk);
    }
    return Results.NotFound();
});


app.Run();

class Book
{
    public int BookId
    { 
        get;
        set;

    }
    public string BookName
    {
        get;
        set;

    }
    public string Author
    {
        get;
        set;

    }
}

class BookContext:DbContext
{
    public BookContext(DbContextOptions<BookContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
    
}
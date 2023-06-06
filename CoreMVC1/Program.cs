using CoreMVC1.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
/*builder.Services.AddDbContext<GadgetContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("GadgetConnection")));
*/


builder.Services.AddDbContext<DbapproachContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.UseEndpoints(Endpoint => Endpoint.MapControllers());


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "mygadget",
    pattern: "{controller=MyGadget}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "inventories",
    pattern: "{controller=Inventories}/{action=Index}/{id?}");



app.Run();

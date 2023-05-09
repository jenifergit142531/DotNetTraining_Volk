

class Cond
{
    public static void library()
    {
        int bookCode;
        Console.WriteLine("Enter the Book code  :");
        bookCode=Convert.ToInt32(Console.ReadLine());
        switch(bookCode)
        {
            case 100:
            Console.WriteLine("Comic book !! return to ");
            break;
            case 200:
            Console.WriteLine("Thriller books !! return to row 312");
            break;
            case 300:
            Console.WriteLine("Crime novels !!! return to row 420");
            break;
            default :
            Console.WriteLine("Looks like a magazine");
            break;
        }
    }
    public void discount()
    {
        int amount;
        Console.WriteLine("Enter the purchase amount");
        amount = Convert.ToInt32(Console.ReadLine());
        if (amount > 0 && amount < 1000)
        {
            Console.WriteLine("Avail discount of 50%");
        }
        else if (amount > 1000 && amount < 5000)
        {
            Console.WriteLine("Avail discount of 60%");
        }
        else
        {
           Console.WriteLine("Not eligible for discounts"); 
        }
    }
}
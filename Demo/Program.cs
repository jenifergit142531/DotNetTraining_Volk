
class Program
{
    public static void Main(string[] args)
    {
        string bookName,paymentMode;
        long cardNo;
        int pin;

        Console.WriteLine("Please enter the book name to bill ");
        bookName=Console.ReadLine();
        Console.WriteLine("How do you like to pay (Debit / Credit)");
        paymentMode=Console.ReadLine();
        Console.WriteLine("Enter your 7 digit card number ");
        cardNo=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your 4 digit pin");
        pin=Convert.ToInt32(Console.ReadLine());
        if(pin==1234)
        {
            Console.WriteLine("Payment is successfull and your book {0} will be delivered in 5 days",bookName);
        }
        else{
            Console.WriteLine("Invalid pin");
        }



        //string bookName  = "Ikigai";

        //Console.WriteLine("Hello world   " + bookName);
       //Console.WriteLine("Hello world {0}",bookName);
    }
}

class Looping
{
    public static void Execute()
    {
        int n1=0,n2=1,n3;
        int number;
        Console.WriteLine("Fibonacci series");
        Console.WriteLine("Enter the number of elements :");
        number=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n1 + "  " + n2+"  ");
        do
       //while(number < 10)
       //for(int i=0;i<number;i++)
        {
            n3=n1+n2;
            Console.WriteLine(n3+"");
            n1=n2;
            n2=n3;
            number++;
        }while(number<10);


    }
}

//Declare the delegate

public delegate void delOne();

public delegate void delTwo(int i,int j);

//Generic delegate

public delegate T delThree<T>(T x,T y);

class SingleCast{

    public static void display()
    {
        Console.WriteLine("Hello delegate");
    }
    public static void add(int a,int b)
    {
        Console.WriteLine("Sum is :{0}",a+b);
    }
     public static void Subtract(int a,int b)
    {
        Console.WriteLine("Subtraction is :{0}",a-b);
    }
     public static void Multiply(int a,int b)
    {
        Console.WriteLine("Multipled value is :{0}",a*b);
    }
     public static void Divide(int a,int b)
    {
        Console.WriteLine("Divide is :{0}",a/b);
    }
    public static string Concat(string a,string b)
    {
       return a+b;
    }

   public static int addition(int a,int b)
    {
        return a+b;
    }


}
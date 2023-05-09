
class Casting
{
    public static void cast()
    {


       //Implicit conversion
        short a=10;
        int b= a;
        Console.WriteLine(b);
        //Explicit conversion
        double c=12.34;
        int d=(int)c;
        Console.WriteLine(d);

        //boxing

        object ob1=b;

        //Unboxing

        int result=(int)ob1;

        Console.WriteLine(ob1);
        Console.WriteLine(result);

        
            }
}
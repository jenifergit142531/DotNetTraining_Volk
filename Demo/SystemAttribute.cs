class SystemAttribute
{
    [Obsolete("Dont use Method1() instead use Method2()",true)]
    public static void Method1()
    {
      Console.WriteLine("This is a old method");
    }
    public static void Method2()
    {
     Console.WriteLine("This is a new method");
    }
}
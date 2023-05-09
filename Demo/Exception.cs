
public class VolumeException : System.Exception
{
    public VolumeException(string message):base(message)
    {

    }
}

public class Exception
{
    
    //user defined exception or custom exception
  public static void volumeCheck()
  {
    int volume;
    try
    {
        
        Console.WriteLine("Enter the volume level");
        volume=Convert.ToInt32(Console.ReadLine());
        if(volume > 100)
        {
            throw new VolumeException("Its too loud,Reduce the volume to 30");
        }
        
    }
    catch(VolumeException ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally{
        Console.WriteLine("all good and done");
    }
  }


    //Sytem exception or built in exception
    public static void divide()
    {
        int n,d;
        Console.WriteLine("Enter the numerator :");
        n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the denominator :");
        d=Convert.ToInt32(Console.ReadLine());
        int result;
        try{
            result=n/d;
            Console.WriteLine("Result :"+result);
        }
        catch(ArithmeticException ex)
        {
            Console.WriteLine("Do not divide by zero" + ex.Message);
        }
        finally{
            Console.WriteLine("all good and done");
        }
        
        
    }
}
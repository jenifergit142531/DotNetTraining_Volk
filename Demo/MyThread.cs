
public class MyThread
{
    public void Worker1()
    {
        lock(this)
        {
          for(int i=1;i<=5;i++)
            {
            Console.WriteLine("Worker 1 is called");
            Thread.Sleep(500);
            }
        
        }
        
       
    }
    public static void Worker2()
    {
        for(int i=1;i<=5;i++)
        {
        Console.WriteLine("Worker 2 is called");
        Thread.Sleep(500);
        }
    }
}
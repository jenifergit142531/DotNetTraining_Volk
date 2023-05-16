
class ForeThread
{
    public static void Work1()
    {
        for(int i =1;i<=5;i++)
        {
            Console.WriteLine("Worker 1 in progress");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Worker 1 completed");
    }
}
public class Tasking
{
    public static async Task Printer1()
    {
        await Task.Run(()=>
        {
            for(int i=1;i<=5;i++)
        {
            Console.WriteLine("Printer 1 value:"+i);
            Task.Delay(500).Wait();
        }
        });
        
    }
     public static async Task Printer2()
    {
        await Task.Run(()=>
        {
        for(int i=1;i<=5;i++)
        {
            Console.WriteLine("Printer 2 value:"+i);
            Task.Delay(500).Wait();
        }
        });
    }
}
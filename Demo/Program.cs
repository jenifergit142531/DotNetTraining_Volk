class Program
{
    public static void Main(string[] args)
    {

        Task mytask=new Task(DependentTask.ShowFile);
        mytask.Start();
        mytask.Wait();

        // Tasking.Printer1();
        // Tasking.Printer2();

        // Console.WriteLine("Main thread completed");
        

        // Task t1=Task.Run(() =>
        // {
        //     Tasking.Printer1();
        // });
        // Tasking.Printer2();

        // Thread t1=new Thread(ForeThread.Work1)
        // {
        //     IsBackground=true
        // };
        // Console.WriteLine($"Thread 1 is a background thread :{t1.IsBackground}");
        // t1.Start();
        // Console.WriteLine("Main thread quits");
        // MyThread m=new MyThread();
        // //new
        // Thread t1=new Thread(m.Worker1);
        // Thread t2=new Thread(MyThread.Worker2);

        // //runnable
        
        // t1.Start();
        // t2.Start();
        // //t2.Join();

    }
}
  

class Datetime
{
    public static void getDate()
    {
        DateTime dt=new DateTime(2023,05,09);
        TimeSpan ts=new TimeSpan (24,20,20);

        DateTime newDate=dt.Add(ts);
        Console.WriteLine("New Date :"+newDate);

        DateTime dt2=DateTime.Now;
        DateTime dt3=DateTime.MinValue;
        DateTime dt4=DateTime.MaxValue;
        DateTime dt5=DateTime.Today;


        Console.WriteLine(dt2.ToString());
         Console.WriteLine(dt3.ToString());
          Console.WriteLine(dt4.ToString());
           Console.WriteLine(dt5.ToString());

        

    }
}

public delegate void MyDelagate1();
public delegate void MyDelegate2();


class GenerateEvent
{
     public event MyDelagate1 Press;
     public event MyDelegate2 Remote;


     public void RaiseEvent()
     {
        Press();
        Remote();
     }

     public void alarm()
     {
        Console.WriteLine("Wake up!! wake up");
     }

     public void Television()
     {
        Console.WriteLine("Changing channels in the TV");
     }




}
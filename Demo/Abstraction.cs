
//abstract class 
 class Movie
{
    //abstract method
  //public abstract void movieList();

  public virtual void movieList()
  {
    Console.WriteLine("This is a virtual method");
  }


//concrete method
  public void showTiming()
  {
    Console.WriteLine("Three shows : Morning,Matinee and Night show ");
  }
}

class Bollywood : Movie
{
    public override void movieList()
    {
        Console.WriteLine("1.Ek tha Tiger \n 2.Bramasthra \n 3.Pathan");
    }
}

class Hollywood : Movie 
{
    public override void movieList()
    {
        Console.WriteLine("1.Tenet \n 2.F&F 3.Interstellar ");
    }
}
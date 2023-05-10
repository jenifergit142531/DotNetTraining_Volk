
class Vehicle
{
    public string brand;
    public string transmission;
    public int price;

    public void Display()
    {
       Console.WriteLine("This is a base class - vehicle ");
    }

}
class Car : Vehicle
{
   public void Get()
   {
      Console.WriteLine("Give the car details :");
      Console.WriteLine("Enter Brand :");
      brand=Console.ReadLine();
      Console.WriteLine("Enter transmission :");
      transmission=Console.ReadLine();
      Console.WriteLine("Enter Price :");
      price=Convert.ToInt32(Console.ReadLine());

   }
   public void show()
   {
     Console.WriteLine("You bought a car {0} at a price of Rs.{1}",brand,price);
   }
}
class Bus : Vehicle
{
    public void getBus()
    {
        Console.WriteLine("Enter the Bus transmission type :");
        transmission=Console.ReadLine();

    }
    public void displayBus()
    {
     Console.WriteLine("The bus has {0} transmission",transmission);
    }
}

// class Ford : Car
// {
//     public void newsUpdate()
//     {
//         Console.WriteLine("No productions units in India");
//     }
// }
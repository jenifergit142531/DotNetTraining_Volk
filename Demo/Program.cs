class Program
{
    // public static void Invoke()
    // {
    //     TicketingSystem ts1=new TicketingSystem();  //invoke empty contructor
    //    // TicketingSystem ts2=new TicketingSystem("Chennai",5); // invoke parameter constructor
    //     //TicketingSystem ts3=new TicketingSystem(ts2); //invoke copy constructor
    //   // ts2.show();
    // }

    // public static void DisplayTuple(Tuple<int,string,double,string> product)
    // {
    //     Console.WriteLine($"ProductId={product.Item1}");
    //     Console.WriteLine($"ProductName={product.Item2}");
    //     Console.WriteLine($"Price ={product.Item3}");
    //     Console.WriteLine($"Location ={product.Item4}");

    // }
    public static void Main(string[] args)
    {

        Store s1=new Store();
        //s1.displayItem();
       // s1.MultiDisplay();
     s1.JaggedArray();
    //    var product=Tuple.Create(101,"Bread",45.56,"Pune");
    //    DisplayTuple(product);

 


       // Car c1=new Car();
       // c1.Get();
        //c1.show();
        // Ford f1=new Ford();
        // f1.newsUpdate();
        // f1.Get();
        // f1.show();
        // Bus b1=new Bus();
        // b1.getBus();
        // b1.displayBus();

        // Overload  o1=new Overload();
        // o1.Fashion("Summer","Flowery",12);
        // o1.Fashion();
        // int newPrice=o1.Fashion("checkered",12000);
        // Console.WriteLine("New price =>"+newPrice);

       
           //show();

        //    Program.Invoke();

//     ColorCode cd1=ColorCode.Red;
//      ColorCode cd2=ColorCode.blue;
//       ColorCode cd3=ColorCode.green;

//       Console.WriteLine("Red colour code : "+(int)cd1);
//   Console.WriteLine("Blue colour code : "+(int)cd2);
//     Console.WriteLine("Green colour code : "+(int)cd3);

// Employee emp=new Employee(100);
// //emp.Set(100);
// emp.Get();


// var v1=new Person()
// {
//    FirstName="Jeni",
//    LastName="Y",
//    Address = "Chennai",
//    PhoneNumber=12345
// };

// var v2=v1 with {Address="Pune"};
// Console.WriteLine(v1);
// Console.WriteLine(v2);

    }
}
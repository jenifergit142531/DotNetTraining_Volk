class Program
{
    public static void Main(string[] args)
    {
        //Event

        GenerateEvent event1=new GenerateEvent();
        event1.Press +=  new MyDelagate1(event1.alarm);  
        event1.Remote +=  new MyDelegate2(event1.Television);
        event1.RaiseEvent();



    //     //Predicate Delegate
    //     Predicate<string> check=PredicateDelegate.isUpperCase;
    //     bool result= check("hello");
    //     Console.WriteLine("Predicate regular :"+result);

    //     //Predicate delegate using lambda expression 
    //    Predicate<int> age = (int age) => ( age>18 );
    //     Console.WriteLine(age(5));

    //     //Predicate delegate using anonymous functions 

    //    Predicate<int> prnt = delegate(int age) {
    //     return age>18; 
    //    };

    //    Console.WriteLine(prnt(55));



        // //Action Delegate
        // Action<int> display=ActionDelegate.print;
        // display(10);

        // //action delegate using lambda expression
        // Action<int> show=i=>Console.WriteLine(i*i);
        // show(20);

        // //action delegate using anonymous method
        // Action<int> print=delegate(int i)
        // {
        //     Console.WriteLine("Inside anonymous functions :{0}",i*i);
        // };
        // print(30);




//function delegate

    //Func<int,int,int,int> f1=FuncDelegate.sum;  //Set to target method
    //Func<int,int,int,int> f1= (x,y,z)=>x+y+z;   //Lambda Expression
    // Anonymous functions - no function definition is available
    // Func<int> generateRandom = delegate()
    // {
    //     Random rnd=new Random();
    //     return rnd.Next(1,20);
    // };
    // Console.WriteLine(generateRandom());



    // int result = f1(10,20,30);
    // Console.WriteLine("Result :"+result);


        //set the target method 
    //    delOne d1=new delOne(SingleCast.display);

    //    delTwo d2=new delTwo(SingleCast.add);

    //    d2 += new delTwo(SingleCast.Subtract);
    //    d2 += new delTwo(SingleCast.Multiply);
    //    d2 += new delTwo(SingleCast.Divide);

    //    delThree<string> d3=SingleCast.Concat;

    //    delThree<int> d4=SingleCast.addition;

    //    //Invoke the delegate

    // //    d1();
    // //    d2(100,20);

    // string result1= d3("hello","world");
    // int result2 = d4(400,500);

    // Console.WriteLine(result1);
    // Console.WriteLine(result2);

    }
}

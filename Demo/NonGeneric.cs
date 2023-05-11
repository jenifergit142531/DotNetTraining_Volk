using System.Collections;
class NonGeneric {

//Stack : LIFO(Last in first out),Push - add ,pop - delete
    public static void MyStack()
    {
       Stack plates = new Stack();
       plates.Push("Ceramic Plate");
       plates.Push("glass Plate");
       plates.Push(5);
       plates.Push("Wooden Plate");
       plates.Push(5.67);
       plates.Push("Silver Plate");
       foreach(var i in plates)
       {
        Console.WriteLine(i);
       }
   Console.WriteLine("_______________________");
       plates.Pop();
       plates.Pop();

       foreach(var i in plates)
       {
        Console.WriteLine(i);
       }


    }

    //Queue - First In first Out - Enqueue: add,Dequeue : delete Eg:Ppl in queue - Movie Tickets
    public static void MyQueue()
    {
        Queue MovieTickets =  new Queue();
        MovieTickets.Enqueue("Row 1 - Seat 1 - 10");
        MovieTickets.Enqueue("Row 2 - Seat 11 - 20");
        MovieTickets.Enqueue(5);
        MovieTickets.Enqueue(5.567);
        foreach(var i in MovieTickets)
        {
            Console.WriteLine(i);
        }
       Console.WriteLine("_______________________");
       MovieTickets.Dequeue();
        MovieTickets.Dequeue();
        foreach(var i in MovieTickets)
        {
            Console.WriteLine(i);
        }
      

    }
    
    //ArrayList - Dynamic arrays.Collection of datas of different data types.
    public static void MyArrayList()
    {
        ArrayList grades=new ArrayList();
       // grades.Add(1);
        grades.Add("Second");
       // grades.Add(3);
        grades.Add("Fourth");
       //  grades.Add(5);
        grades.Add("Six");
       //  grades.Add(7);
        grades.Add("Eight");
        // grades.Add(9);

        Console.WriteLine("Current length :"+grades.Count);
        Console.WriteLine("Total capacity :"+grades.Capacity);
         grades.Sort();
         grades.Reverse();
        foreach(var i in grades)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine(grades.Contains("Eight"));

    }

    //Hashtable - contains key , value pair
    public static void MyHashTable()
    {
        Hashtable deptCode=new Hashtable();
        deptCode.Add(1,"HR");
        deptCode.Add(2,"Sales");
        deptCode.Add(3,"SE");
        deptCode.Add(4,"Manager");

       foreach(var i in deptCode.Keys)
       {
        Console.WriteLine(deptCode[i]);
       }

    }
}

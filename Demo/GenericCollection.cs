using System.Collections.Generic;
class GenericCollection
{
    //List - Collection of data stored in a memory location.
    public static void MyList()
    {
       List<int> productCode=new List<int>();
       productCode.Add(101);
       productCode.Add(501);
        productCode.Add(301);
         productCode.Add(201);
          productCode.Add(001);

          List<int> newlist=new List<int>();
          int[] ar=new int[5];
       

             productCode.CopyTo(ar);

 Console.WriteLine(productCode.Count);
 Console.WriteLine(productCode.Contains(200));
 Console.WriteLine();
      foreach(var i in productCode)
      {
        Console.WriteLine(i);
      }

    Console.WriteLine("*********************");

      foreach(var i in ar)
      {
        Console.WriteLine(i);
      }



    }

    //Linked List - Linear data structure that stores the data in non-contiguous location
    // Node - refers to element on the list
    // Node - Data + next(link that points to the other data)
    //Head node - start node
    //Last node - always points to numm
    public static void MyLinkedList()
    {
        LinkedList<string> FrenchToast=new LinkedList<string>();
        FrenchToast.AddFirst("Sugar");
        FrenchToast.AddLast("bread");
        FrenchToast.AddFirst("Milk");
        FrenchToast.AddLast("Butter");

       
       LinkedListNode<string> middle=FrenchToast.AddLast("eggs");

        FrenchToast.AddAfter(middle,"Cookies");
        
        FrenchToast.AddBefore(middle,"Fresh juice");

        foreach(var i in FrenchToast)
        {
            Console.WriteLine(i);
        }
    }

    public static void MyGenericStack()
    {

    }
    public static void MyGenericQueue()
    {

    }

}
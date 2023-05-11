using System.Reflection;

class Program
{
    public static void Main(string[] args)
    {


        DoubleNode first=new DoubleNode();
        first.data=5;
        first.nextLink=null;
        first.prevLink=null;

        DoublyLinkedList Doublylist=new DoublyLinkedList();
        Doublylist.head=first;
        
        DoubleNode second=new DoubleNode();
        second.data=10;
        second.nextLink=null;
        second.prevLink=first;
        first.nextLink=second;

        DoubleNode third=new DoubleNode();
        third.data=15;
        third.nextLink=null;
        third.prevLink=second;
        second.nextLink=third;

        DoubleNode fourth=new DoubleNode();
        fourth.data=20;
        fourth.nextLink=null;
        fourth.prevLink=third;
        third.nextLink=fourth;

        Doublylist.DoublyForward();
        Doublylist.DoublyReverse();





    //     Node first=new Node();
    //     first.data=5;
    
    //     first.link=null;


    //     LinkedList myList=new LinkedList();
    //     myList.head=first;   // first node is the head node 


    //     Node second=new Node();
    //     second.data=10;
    //     first.link=second;


    //     Node third=new Node();
    //     third.data=15;
    //     second.link=third;

    //     Node fourth=new Node();
    //     fourth.data=20;
    //     third.link=fourth;
    //     //fourth.link=first;


    //    myList.MySinglyListDisplay();

        //GenericCollection.MyList();
        //GenericCollection.MyLinkedList();

        //NonGeneric.MyStack();
        //NonGeneric.MyQueue();
        //NonGeneric.MyArrayList();
        //NonGeneric.MyHashTable();

        // Banking b=new Banking();
        // b.SetDetails(101,"Jeni",2000);
        // Console.WriteLine("Account Details :");
        // Console.WriteLine("Account holder name is {0} and have a balance of {1}",b.getAccountHolderName(),b.getAvailableBalance());
       // SystemAttribute.Method2();
        //Reflection.MetadataInfo();

        // Assembly exec=Assembly.GetExecutingAssembly();

        // Type[] types=exec.GetTypes();

        // foreach(var item in types)
        // {
        //     Console.WriteLine("Class Name :"+item.FullName);

        //     MethodInfo[] methods=item.GetMethods();
        //     foreach(var method in methods)
        //     {
        //         Console.WriteLine("Method Name : " +method.Name);

        //         ParameterInfo[] parameters=method.GetParameters();
        //         foreach(var p in parameters)
        //         {
        //             Console.WriteLine("Parameters :"+p.Name);
        //             Console.WriteLine("Parameter Type :"+p.ParameterType);
        //         }
        //     }
        // }


    }
}

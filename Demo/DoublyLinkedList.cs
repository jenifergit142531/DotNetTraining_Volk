

class DoubleNode
{
    public int data;
    public DoubleNode prevLink;
    public DoubleNode nextLink;
}

class DoublyLinkedList
{
    public DoubleNode head;

    public DoublyLinkedList()
    {
        head=null;
    }

    // display the content of the list 
    
    public void DoublyForward()
    {
     DoubleNode temp=new DoubleNode();
     temp=this.head;
     if(temp!=null)
     {
        Console.WriteLine("The list elements are :");
        while(temp!=null)
        {
            Console.WriteLine("Data :" +temp.data);
            temp=temp.nextLink;
        }

     }  
     else{
        Console.WriteLine("The list is empty");
     } 
    }

    public void DoublyReverse()
    {

        Console.WriteLine("The list in reverse contains :");

         DoubleNode tail=new DoubleNode();
         tail=this.head;
       //Traversing to the tail of the list
         while(tail.nextLink!=null)
         {
            tail=tail.nextLink;
         }

         //Traverse from tail to head and print the data

         while(tail!=head)
         {
            Console.WriteLine("Data :"+tail.data);
            tail=tail.prevLink;
         }

         Console.WriteLine("Data :" + tail.data);
         

    }

}
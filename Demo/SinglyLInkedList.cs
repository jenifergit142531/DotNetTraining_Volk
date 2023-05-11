
class Node
{
    public int data;
    public Node link;
}

class LinkedList
{
    public Node head;

    public LinkedList()
    {
        head=null;
    }

    // display the content of the list 
    
    public void MySinglyListDisplay()
    {
     Node temp=new Node();
     temp=this.head;
     if(temp!=null)
     {
        Console.WriteLine("The list elements are :");
        while(temp!=null)
        {
            Console.WriteLine("Data :" +temp.data);
            temp=temp.link;
        }

     }  
     else{
        Console.WriteLine("The list is empty");
     } 
    }

}
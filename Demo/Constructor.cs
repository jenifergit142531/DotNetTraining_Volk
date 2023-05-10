

class TicketingSystem
{
    string loc;
    int tickets;
    //empty constructor
    public TicketingSystem()
    {
       Console.WriteLine("No traffic violation and zero tickets so far");
    }
    //parameterized constructor 
    public TicketingSystem(string location,int noTickets)
    {
      loc=location;
      tickets=noTickets;
    }
    //copy constructor
    // public TicketingSystem(TicketingSystem ts)
    // {
    //   Console.WriteLine("Ticketing system created");
    //   this.loc=loc;
    //   this.tickets=tickets;
      
    // }

    public void show()
    {
      Console.WriteLine(loc);
      Console.WriteLine("New fine :{0}", tickets);
    }
 ~TicketingSystem()
 {
   Console.WriteLine("Destructor is invoked");
 }
    
}

using Newtonsoft.Json;

[Serializable]
public class HollywoodMovie
{
    public string movieName;
    public int ticketPrice;

    public void movieList()
    {
      List<HollywoodMovie> ls=new List<HollywoodMovie>();
      ls.Add(new HollywoodMovie()
      {
       movieName="Jurassic park",
       ticketPrice=300
      });
      ls.Add(new HollywoodMovie()
      {
       movieName="Tenet",
       ticketPrice=250
      });
      ls.Add(new HollywoodMovie()
      {
       movieName="Lego",
       ticketPrice=200
      });


   //JSON Serialization
      string memory = JsonConvert.SerializeObject(ls);

      //JSON Deserialization
      List<HollywoodMovie> deObj=JsonConvert.DeserializeObject<List<HollywoodMovie>>(memory);
      foreach(var i in deObj)
      {
        Console.WriteLine("Movie Name :"+i.movieName);
        Console.WriteLine("Ticket Price :"+i.ticketPrice);
      }




    }

    

    
    
}
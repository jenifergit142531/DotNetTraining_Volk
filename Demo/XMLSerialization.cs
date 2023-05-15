
using System.Xml.Serialization;

[Serializable]
public class BollywoodMovie
{
    public string movieName;
    public int ticketPrice;

    public BollywoodMovie()
    {
        movieName="Pathan";
        ticketPrice=200;
    }

    public void XMLSerialize()
    {
      XmlSerializer xs=new XmlSerializer(typeof(BollywoodMovie));
      TextWriter tw=new StreamWriter("C:/Users/JeniferY/Desktop/AAA/xmlfile.xml");
      BollywoodMovie bwm=new BollywoodMovie();
      xs.Serialize(tw,bwm);
      tw.Close();
    }

    public void XMLDeSerialize()
    {
    XmlSerializer xs=new XmlSerializer(typeof(BollywoodMovie));
      TextReader tr=new StreamReader("C:/Users/JeniferY/Desktop/AAA/xmlfile.xml");
      BollywoodMovie bwm=(BollywoodMovie)xs.Deserialize(tr);
      Console.WriteLine("Movie Name :"+bwm.movieName);
      Console.WriteLine("Ticket Price :"+bwm.ticketPrice);
      tr.Close();
    }
}
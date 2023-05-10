
class Overload
{
    public void Fashion()
    {
        Console.WriteLine("Retro is all time fashion");
    }
    public void Fashion(string season,string designs,int newModels)
    {
     Console.WriteLine("{0} launched {1} design and has over {2} models in India ",season,designs,newModels);
    }
    public int Fashion(string model,int price)
    {
        return price*45;
    }
}
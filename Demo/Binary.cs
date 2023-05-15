
public class Binary
{
    public static void BinaryWrite()
    {
        using(BinaryWriter bw=new BinaryWriter(File.Open("C:/Users/jenifery/may_vd/c#class6/MyFiles/BinaryFile4.dat",FileMode.OpenOrCreate)))
        {
          bw.Write(10);
      
          bw.Write(true);
       // bw.Write("This is string");
          bw.Write(12.34);
        }
    }
      public static void BinaryRead()
    {
        using(BinaryReader br=new BinaryReader(File.Open("C:/Users/jenifery/may_vd/c#class6/MyFiles/BinaryFile4.dat",FileMode.OpenOrCreate)))
        {
            Console.WriteLine("Double :"+br.ReadDouble());
         
            Console.WriteLine("Boolean :"+br.ReadBoolean());
           Console.WriteLine("Integer :"+br.ReadInt16());
             //  Console.WriteLine("String :"+br.ReadString());
        }
        
    }
}
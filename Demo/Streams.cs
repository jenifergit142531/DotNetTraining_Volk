
class Streams
{
    public static void StreamWrite()
    {
        FileStream fs=new FileStream("C:/Users/jenifery/may_vd/c#class6/MyFiles/StreamFile.txt",FileMode.OpenOrCreate);
        {
          StreamWriter sw=new StreamWriter(fs);
          sw.WriteLine("Hello Stream writer");
          sw.Close();
          fs.Close();
          
        }
    }
    public static void StreamRead()
    {
        FileStream fs=new FileStream("C:/Users/jenifery/may_vd/c#class6/MyFiles/StreamFile.txt",FileMode.OpenOrCreate);
        {
         StreamReader sr=new StreamReader(fs);
         string line=sr.ReadLine();
         Console.WriteLine(line);
         sr.Close();
         fs.Close();
        }

    }
}
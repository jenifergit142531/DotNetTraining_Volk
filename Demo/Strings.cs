using System.Text;

class StringFiles
{

    public static void StringOps()
    {
       string text="Hello,welcome to the string builder class";

       StringBuilder sb=new StringBuilder();

       //String Writer
       StringWriter sw=new StringWriter(sb);
       sw.WriteLine(text);
       sw.Close();

       //String Reader
       StringReader sr=new StringReader(sb.ToString());
       while(sr.Peek()>-1)
       {
        Console.WriteLine(sr.ReadLine());
       }


       
    }
}
   

    
    

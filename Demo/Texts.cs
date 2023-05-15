

class Texts
{
    public static void TextWrite()
    {
        using(TextWriter tw=File.CreateText("C:/Users/jenifery/may_vd/c#class6/MyFiles/TextFile.txt"))
        {
            tw.WriteLine("Book Name : Alchemist");
            tw.WriteLine("This book talks about the journey of life ");
        }

    }
    public static void TextRead()
    {
        using(TextReader tr=File.OpenText("C:/Users/jenifery/may_vd/c#class6/MyFiles/TextFile.txt"))
        {
            Console.WriteLine(tr.ReadToEnd());
        }

    }
}
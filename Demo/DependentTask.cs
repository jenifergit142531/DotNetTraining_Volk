

public class DependentTask
{
    public static async void ShowFile()
    {
       string filepath="C:/Users/jenifery/may_vd/c#class7/Notes/notex.txt";
       Task<int> t1=ReadFile(filepath);
       int length = await t1;
       Console.WriteLine("length of the file " +length);

    }
    public static async Task<int> ReadFile(string filename)
    {
            int length=0;
            Console.WriteLine("Started to read the file");
            using(StreamReader sr=new StreamReader(filename))
            {
                string s=await sr.ReadToEndAsync();
                length=s.Length;
            }
            Console.WriteLine("File reading is completed");
            return length;
    }
}
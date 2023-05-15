

public class MyDirectory
{
    public static void CreateDirectory()
    {
        DirectoryInfo dir=new DirectoryInfo("C:/Users/JeniferY/May_Vd/c#class6/MyFiles");
        try
        {
            if(dir.Exists)
            {
                Console.WriteLine("This directory already exists");
            }
            else
            {
                dir.Create();
                Console.WriteLine("Directory is successfully created");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
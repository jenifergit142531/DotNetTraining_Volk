
class Reflection
{
    public static void MetadataInfo()
    {
        Type t = typeof(int);
        Console.WriteLine("Name :"+t.Name);
        Console.WriteLine("Full Name :"+t.FullName);
        Console.WriteLine("Namespace :"+t.Namespace);
        Console.WriteLine("Base TYpe : "+t.BaseType);
        Console.WriteLine("Check id: "+t.GUID);

    }


}

class Student
{
    public int RollNo
    {
        get;
        set;
    }
    public string Name{
        get;
        set;
    }
    public Student()
    {
        RollNo=0;
        Name=string.Empty;
    }
    public void Display()
    {
        Console.WriteLine("Roll Number :"+RollNo);
        Console.WriteLine("Student Name :"+Name);
    }
}
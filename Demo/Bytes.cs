public class Bytes{
    public static void ByteWrite()
    {
        FileStream fs=new FileStream("C:/Users/jenifery/may_vd/c#class6/MyFiles/ByteFile.txt",FileMode.OpenOrCreate);
        {
            for(int i =65;i<=90;i++)
            {
                fs.WriteByte((byte)i);
            }
            Console.WriteLine("Byte File is successfully created");
            fs.Close();

        }
    }
    public static void ByteRead()
    {
        FileStream fs=new FileStream("C:/Users/jenifery/may_vd/c#class6/MyFiles/ByteFile.txt",FileMode.OpenOrCreate);
        {

            int i=0;
            while((i=fs.ReadByte())!=-1)
            {
                Console.WriteLine((char)i);
            }
            Console.WriteLine("Byte File is read successfully ");
            fs.Close();
        }
    }
}
using System.Xml;
class XMLApplication
{
    public static void XMLWrite()
    {
    XmlWriterSettings xws=new XmlWriterSettings();
    xws.Indent=true;
    XmlWriter xw=XmlWriter.Create("C:/Users/jenifery/may_vd/c#class6/MyFiles/Student.xml",xws);
    xw.WriteStartDocument();
    xw.WriteStartElement("student");
    xw.WriteAttributeString("id","101");
   xw.WriteAttributeString("Status","pass");
    xw.WriteElementString("firstname","Mitra");
    xw.WriteElementString("lastname","Ajith");
    xw.WriteElementString("grade","first");
    xw.WriteEndElement();
    xw.WriteEndDocument();
    xw.Close();
    Console.WriteLine("The XML File is created and data is updated");
    }
    public static void XMLRead()
    {
        XmlReaderSettings xrs=new XmlReaderSettings();
        xrs.IgnoreWhitespace=true;
        XmlReader xr=XmlReader.Create("C:/Users/jenifery/may_vd/c#class6/MyFiles/Student.xml",xrs);
        xr.MoveToContent();
        Console.WriteLine(xr.AttributeCount);
        Console.WriteLine(xr["id"]);
        Console.WriteLine(xr["Status"]);
        xr.MoveToContent();
        xr.ReadStartElement("student");
    
       Console.WriteLine(xr.ReadElementContentAsString("firstname",""));
       Console.WriteLine(xr.ReadElementContentAsString("lastname",""));
       Console.WriteLine(xr.ReadElementContentAsString("grade",""));
        
        xr.ReadEndElement();
        xr.Close();
        
         }
}
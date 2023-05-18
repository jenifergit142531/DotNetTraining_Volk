using MyLINQSQL;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main(string[] args)
    {

        string con = System.Configuration.ConfigurationManager.ConnectionStrings["DemoConnectionString(LinqSQL)"].ToString();
        DataClasses1DataContext db = new DataClasses1DataContext(con);

        Eproduct ep = new Eproduct();
        ep.pid = 102;
        ep.pname = "iphone14";

        db.Eproducts.Add(ep);


        Eproduct result = db.Eproducts.FirstOrDefault(db.Eproducts.contains(102));
        Console.WriteLine(result.pname);
    }


}
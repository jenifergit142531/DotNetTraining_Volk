using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class Class1
    {
    }

    public class DatabaseLayer1
    {
        SqlConnection con = new SqlConnection("Data Source=REV-PG02C4Y5;Initial Catalog=Demo;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");


        public void add(int id,string name)
        {
            SqlDataAdapter sda = new SqlDataAdapter("insert into gaming values('" + id + "','" + name + "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

        public DataTable select()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from gaming", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }


    }
}

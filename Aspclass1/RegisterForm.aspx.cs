using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aspclass1
{
    public partial class RegisterForm : System.Web.UI.Page
    {
        string conString = "Data Source=REV-PG02C4Y5;Initial Catalog=Demo;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from empengagement", con);
            sda.Fill(ds);
            Chart1.DataSource = ds;

        }
    }
}
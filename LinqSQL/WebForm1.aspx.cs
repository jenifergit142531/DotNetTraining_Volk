using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqSQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GamingDataContext gd = new GamingDataContext();
            var result = from i in gd.gamings
                         select i;
            GridView1.DataSource = result;
            GridView1.DataBind();


        }
    }
}
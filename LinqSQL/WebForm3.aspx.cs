using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqSQL
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DemoEntities de = new DemoEntities();
            var result = from i in de.Eproducts
                         select
                         new
                         {
                             pid = i.pid,
                             pname = i.pname
                         };


            GridView1.DataSource = result.ToList();
            GridView1.DataBind();
        }
    }
}
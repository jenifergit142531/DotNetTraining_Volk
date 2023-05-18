using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LinqSQL
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                XElement doc = XElement.Load(Server.MapPath("XMLFile1.xml"));
                var result = from i in doc.Descendants("employee")
                             where Convert.ToInt32(i.Element("salary").Value) > 50000
                             select new
                             {
                                 eid = i.Element("empid").Value,
                                 ename=i.Element("ename").Value,
                                 salary=i.Element("salary").Value

                           };

                GridView1.DataSource = result;
                GridView1.DataBind();

            }
        }
    }
}
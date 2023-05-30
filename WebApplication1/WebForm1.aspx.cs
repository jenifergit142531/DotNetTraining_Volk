using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Threading;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected override void InitializeCulture()
        {
            base.InitializeCulture();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Session["Culture"].ToString());
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Session["Culture"].ToString());
        }
        protected void DrpLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Culture"] = DrpLanguages.SelectedValue;
           // Response.Redirect("Runpage.aspx");
        }
    }
}
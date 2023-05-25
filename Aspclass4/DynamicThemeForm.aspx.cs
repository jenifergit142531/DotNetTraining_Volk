using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aspclass4
{
    public partial class DynamicThemeForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_PreInit(object sender,EventArgs e)
        {
            string theme = Request.QueryString["MyTheme"];
             if(theme!=null)
             {
                 Page.Theme = theme;
             }  
             else
            {
                Page.Theme = "default";
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = DropDownList1.SelectedItem.Text;
            Response.Redirect("DynamicThemeForm.aspx?MyTheme="+name);

           
        }
    }
}
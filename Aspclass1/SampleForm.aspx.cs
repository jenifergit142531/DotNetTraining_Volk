using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aspclass1
{
    public partial class SampleForm : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

            Label1.Text += "Page Load event is handled <br/>"
;
            if(Page.IsPostBack)
            {
                Label1.Text += "Page post back event handled <br/>";
            }
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Label1.Text += "Page Initialization event is handled <br/>";
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Label1.Text += "Page prerender event handled <br/>";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text += "Button click event handled <br/>";
        }
    }
  

}
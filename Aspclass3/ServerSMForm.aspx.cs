using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aspclass3
{
    public partial class ServerSMForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application.Lock();
            int count = 0;
            if (Application["visit"] !=null)
            {
                count = Convert.ToInt32(Application["visit"].ToString());
            }
            count = count + 1;
            Application["visit"] = count;
            Application.UnLock();
            Label2.Text="User have visited this application => "+count.ToString();
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (Session["visit"] != null)
            {
                counter = Convert.ToInt32(Session["visit"].ToString());
            }
            counter = counter + 1;
            Session["visit"] = counter;
            
            Label4.Text = "User have visited this application => " + counter.ToString();
        }
    }
}
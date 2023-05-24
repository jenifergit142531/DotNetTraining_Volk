using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aspclass3
{
    public partial class ClientSideForm : System.Web.UI.Page
    {
        public string a, b;
        protected void Page_Load(object sender, EventArgs e)
        {
            //create the cookie

          /*  HttpCookie cookie = new HttpCookie("student");
            cookie.Value = "Aron";
            Response.Cookies.Add(cookie);

            var studentName = Response.Cookies["student"].Value;
            Label8.Text = studentName;*/
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //  TextBox1.Text = a;
            //TextBox2.Text = b;

            if (ViewState["username"] != null)
            {
                TextBox1.Text = ViewState["username"].ToString();
            }
            if (ViewState["password"] != null)
            {
                TextBox2.Text = ViewState["password"].ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeForm.aspx?Name=" + TextBox3.Text + "&Department=" + TextBox4.Text);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Cookies["Bookname"].Value = TextBox5.Text;
            Response.Cookies["Bookname"].Expires = DateTime.Now.AddSeconds(20);
            Label9.Text = "Cookie created";
            TextBox5.Text = "";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["Bookname"]==null)
            {
                Label9.Text = "No cookie found";
            }
            else
            {
                Label9.Text = Request.Cookies["Bookname"].Value;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //  a = TextBox1.Text;
            //  b = TextBox2.Text;

            // TextBox1.Text = TextBox2.Text = string.Empty;

            ViewState["username"] = TextBox1.Text;
            ViewState["password"] = TextBox2.Text;
            TextBox1.Text = TextBox2.Text = string.Empty;

        }
    }
}
using ApplicationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiniProjectForm
{
    public partial class PresentationLayer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ApplicationLayer1 al = new ApplicationLayer1();
            int a = int.Parse(TextBox1.Text);
            string b = TextBox2.Text;
            al.InsertGame(a, b);
            Response.Write("Game record inserted successfully");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ApplicationLayer1 al = new ApplicationLayer1();
            GridView1.DataSource = al.SelectGame();
            GridView1.DataBind();
            GridView1.Visible = true;
        }
    }
}
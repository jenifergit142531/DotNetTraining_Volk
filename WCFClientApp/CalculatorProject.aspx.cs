using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFClientApp
{
    public partial class CalculatorProject : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
     
        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox3.Text);
            ServiceReference1.CalculatorClient sc = new ServiceReference1.CalculatorClient();
            int z = sc.sum(x, y);
            Label4.Text = z.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox3.Text);
            ServiceReference1.CalculatorClient sc = new ServiceReference1.CalculatorClient();
            int z = sc.sub(x, y);
            Label4.Text = z.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox3.Text);
            ServiceReference1.CalculatorClient sc = new ServiceReference1.CalculatorClient();
            int z = sc.multiple(x, y);
            Label4.Text = z.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox3.Text);
            ServiceReference1.CalculatorClient sc = new ServiceReference1.CalculatorClient();
            int z = sc.divide(x, y);
            Label4.Text = z.ToString();
        }
    }
}
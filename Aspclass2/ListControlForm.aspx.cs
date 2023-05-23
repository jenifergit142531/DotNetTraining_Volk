using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aspclass2
{
    public partial class ListControlForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                List<string> ls = new List<string>();
                ls.Add("Amy");
                ls.Add("Peter");
                ls.Add("Patrick");
                ls.Add("Steve");
                ls.Add("Aron");

                ListBox1.DataSource = ls;
                ListBox1.DataBind();

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label6.Text = "You have selected :" +DropDownList1.SelectedItem.Value;
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label6.Text = "You have selected :" + RadioButtonList1.SelectedItem.Text + "</br>" +
                "Value  = " + RadioButtonList1.SelectedValue + "</br>" +
                "Index = " + RadioButtonList1.SelectedIndex;
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ListItem i in ListBox1.Items)
            {
                if (i.Selected)
                {
                    sb.Append(i + "</br>");
                }
            }
            Label6.Text = sb.ToString();
        }

        
       /* protected void Style_Command(object sender,CommandEventArgs e)
        {
            switch(e.CommandName)
            {
                case "Circle":
                    BulletedList1.BulletStyle = BulletStyle.Circle;
                    break;
                case "Disc":
                    BulletedList1.BulletStyle = BulletStyle.Disc;
                    break;
                case "Square":
                    BulletedList1.BulletStyle = BulletStyle.Square;
                    break;
                case "Numbered":
                    BulletedList1.BulletStyle = BulletStyle.Numbered;
                    break;
                case "LowerRoman":
                    BulletedList1.BulletStyle = BulletStyle.LowerRoman;
                    break;
                case "UpperAlphabet":
                    BulletedList1.BulletStyle = BulletStyle.UpperAlpha;
                    break;
            }
        }*/

        protected void Button2_Click(object sender, EventArgs e)
        {
            BulletedList1.BulletStyle = BulletStyle.Disc;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            BulletedList1.BulletStyle = BulletStyle.Circle;
        }
    }
}
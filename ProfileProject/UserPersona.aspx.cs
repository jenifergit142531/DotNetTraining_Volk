using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Configuration;
using System.Web.Profile;

namespace ProfileProject
{
    public partial class UserPersona : System.Web.UI.Page
    {
        ProfileBase Profile { get; }
       


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

          //  Profile.PostalCode = TextBox1.Text;

          

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           // string code = (string)Profile.GetPropertyValue("PostalCode");
           // Label2.Text = code;
        }
    }
}
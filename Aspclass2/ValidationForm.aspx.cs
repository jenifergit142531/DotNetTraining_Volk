using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aspclass2
{
    public partial class ValidationForm : System.Web.UI.Page
    {

        protected void UserIdValidate(object sender,ServerValidateEventArgs args)
        {
            string str = args.Value;
            args.IsValid = false;

            //checking for input length 
            if(str.Length < 6 || str.Length > 25)
            {
                return;
            }

            //Checking for atleast a single capital letter

            bool capital = false;

            foreach(char ch in str)
            {
                if (ch >='A' && ch <='Z')
                {
                    capital = true;
                    break;
                }
            }
            if (!capital)
            {
                return;
            }

            //Checking for atleast a single lower letter

            bool lower = false;

            foreach (char ch in str)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    lower = true;
                    break;
                }
            }
            if (!lower)
            {
                return;
            }

            //Checking for digits

            bool digit = false;

            foreach (char ch in str)
            {
                if (ch >= '0' && ch <= '9')
                {
                    digit = true;
                    break;
                }
            }
            if (!digit)
            {
                return;
            }

            args.IsValid = true;

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
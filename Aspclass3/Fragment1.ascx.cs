﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aspclass3
{
    public partial class Fragment1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Fragment 1 " + DateTime.Now.TimeOfDay.ToString();
        }
    }
}
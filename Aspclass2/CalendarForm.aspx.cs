using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aspclass2
{
    public partial class CalendarForm : System.Web.UI.Page
    {
        Hashtable HolidayList;
        protected void Page_Load(object sender, EventArgs e)
        {
            HolidayList = GetHoliday();

        }

        private Hashtable GetHoliday()
        {
            Hashtable holiday = new Hashtable();
            holiday["5/29/2023"] = "Memorial Day";
            holiday["6/14/2023"] = "Mira Birthday";

            return holiday;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            Label1.Text = e.NewDate.ToShortDateString();
        }

            protected void Calendar1_DayRender(object sender,DayRenderEventArgs e)
        {
            if (HolidayList[e.Day.Date.ToShortDateString()]!=null)
            {
               
                Literal l1 = new Literal();
                l1.Text = "<br/>";
                e.Cell.Controls.Add(l1);
                Label l2 = new Label();
                l2.Text = (string)HolidayList[e.Day.Date.ToShortDateString()];
                l2.Font.Size = new FontUnit(FontSize.Small);
                e.Cell.Controls.Add(l2);
            }
            
        }
    }
}
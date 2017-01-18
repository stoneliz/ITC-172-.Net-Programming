using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] holiday = new string[6, 2];
    
    protected void Page_Load(object sender, EventArgs e)
    {
        holiday[0, 0] = "Martin Luther King Jr Day";
        holiday[0, 1] = "1/16/2017";
        holiday[1, 0] = "President's Day";
        holiday[1, 1] = "2/20/2017";
        holiday[2, 0] = "St. Patrick's Day";
        holiday[2, 1] = "3/17/2017";
        holiday[3, 0] = "Happy Birthday";
        holiday[3, 1] = "4/14/2017";
        holiday[4, 0] = "Get Taxes Done";
        holiday[4, 1] = "4/14/2017";
        holiday[5, 0] = "Mother's Day";
        holiday[5, 1] = "5/14/2017";

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = Calendar1.SelectedDate.ToShortDateString();

        GetHolidays();
    }
      protected void GetHolidays()
       {
        for (int i = 0; i < 6; i++)
           {
            if (Calendar1.SelectedDate.ToShortDateString() == holiday[i,1])
            {
                Label1.Text += " " + holiday[i,0];
            }
            
        }
       }
}
 
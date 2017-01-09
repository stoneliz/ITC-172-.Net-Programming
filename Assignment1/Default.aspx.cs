﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        { 
        string[] tipPercent = { "Ten Percent", "Fifteen Percent", "Twenty Percent", "Other"};
        TipPercentsRadioButtonList.DataSource = tipPercent;
        TipPercentsRadioButtonList.DataBind();
        }
    }
    protected void SubmitButton_Click(object sender, EventArgs e)
    {

    }
    protected void GetInfo()
    {
        Tip tip = new Tip();
        tip.MealAmount = double.Parse(MealTextBox.Text); //parse: converts string to double
        if (OtherTextBox.Text == "")
        {
            tip.TipPercent = 0;
            foreach(ListItem item in TipPercentsRadioButtonList.Items)
                {
                if (item.Selected)
                 {
                    if(item.Text.Equals("TenPercent"))
                    {
                        tip.TipPercent = .1;
                    }
                    else if (item.Text.Equals("FifteenPercent"))
                    {
                        tip.TipPercent = .15;
                    }
                    else if (item.Text.Equals("TwentyPercent"))
                    {
                        tip.TipPercent = .2;
                    }
                }//end if selected
            }//end foreach
        }// end outer if
        else
        {
            tip.TipPercent = double.Parse(OtherTextBox.Text);
        }
        ResultLabel.Text = "Amount: " + tip.MealAmount.ToString() + "<br/>" +
            "Tip: " + tip.CalculateTip().ToString("$#,##0.00") + "<br/>" +
            "Tax: " + tip.CalculateTax().ToString("$#,##0.00") + "<br/>" +
            "Total: " + tip.CalculateTotal().ToString("$#,##0.00");
    }
}
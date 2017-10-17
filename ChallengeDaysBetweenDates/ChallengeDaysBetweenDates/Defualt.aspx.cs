using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Defualt : System.Web.UI.Page
    {

        DateTime cal1, cal2, CALREF;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void resultBtn_Click(object sender, EventArgs e)
        {
            //Set dates
            setDates();
            //check if dates have been selected
            if (!checkIfDateIsSelected())
                return;

            // campare dates
            double daysBetween = findDaysBetween();

            // display result

            resultLabel.Text = daysBetween.ToString();
        }

        private double findDaysBetween()
        {
            return Math.Abs( (cal1 - cal2).TotalDays);
            
        }

        private void setDates()
        {
            cal1 = Calendar1.SelectedDate;
            cal2 = Calendar2.SelectedDate;
        }

        private Boolean checkIfDateIsSelected()
        {
            if(cal1 == CALREF) { return false; }
            if(cal2 == CALREF) { return false; }
            return true;

        }
    }
}
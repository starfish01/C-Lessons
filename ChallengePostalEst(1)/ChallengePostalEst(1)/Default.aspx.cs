using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalEst_1_
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckCalculation();
        }

        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckCalculation();
        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckCalculation();
        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CheckCalculation();
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CheckCalculation();
        }

        protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CheckCalculation();
        }

        private void CheckCalculation()
        {

            if (!CheckTextBoxsAreCorrect())
                return;

            resultLabel.Text = "hello";
        }

        private Boolean CheckTextBoxsAreCorrect()
        {
            double height, width, length;

            if(!double.TryParse(heightTextBox.Text, out height)) { return false; }
            if(!double.TryParse(widthTextBox.Text,out width)) { return false; }
            if(!double.TryParse(lengthTextBox.Text, out length)) { return false; }

            return true;
           
        }
    }
}
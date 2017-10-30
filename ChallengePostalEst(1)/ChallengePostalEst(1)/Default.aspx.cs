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
        PackageClass pC;

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

            pC = new PackageClass();

            resultLabel.Text = "";
           
            if (!CheckTextBoxsAreCorrect())
                return;

            if (!CheckRadioBoxHasBeenSelected())
                return;

            CostToSendPackage();

            DisplayCost();


        }

        private void DisplayCost()
        {
            String costString = (pC.GetCost().ToString("C"));

            String output = String.Format("The cost to send this Package is {0}.", costString);

            resultLabel.Text = output;

        }

        private void CostToSendPackage()
        {
            if (pC.GetLength() == 0)
            {
                pC.SetCostToSend(pC.GetHeight() * pC.GetWidth() * pC.GetTransport());
                return;
            }

            pC.SetCostToSend(pC.GetHeight() * pC.GetWidth()* pC.GetLength() * pC.GetTransport());

        }

        private bool CheckRadioBoxHasBeenSelected()
        {
            if (!(airRadioButton.Checked || groundRadioButton.Checked || nextDayRadioButton.Checked))
                return false;
            if (nextDayRadioButton.Checked)
                pC.SetTrasport(0.45);
            if (airRadioButton.Checked)
                pC.SetTrasport(0.25);
            if (groundRadioButton.Checked)
                pC.SetTrasport(0.15);

            return true;
        }

        private Boolean CheckTextBoxsAreCorrect()
        {
            double height, width, length;
       
            //need to make sure it doesnt matter if its a number or a empty 
            
            if(!double.TryParse(heightTextBox.Text, out height)){ return false; }

            if (!double.TryParse(widthTextBox.Text, out width)){ return false; }

            //optional
            if (!double.TryParse(lengthTextBox.Text, out length)){
                if (String.IsNullOrEmpty(lengthTextBox.Text))
                    length = 0;
                else
                    return false;
            }

            pC.CreatePackage(height, width, length);
            
            
            return true;
           
        }
    }
}
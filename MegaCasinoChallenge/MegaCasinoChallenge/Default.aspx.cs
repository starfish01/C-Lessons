using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaCasinoChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        CasionData casionData;

        protected void Page_Load(object sender, EventArgs e)
        {

            casionData = new CasionData();

            if (ViewState["MegaCasionData"] != null)
            {
                casionData = (CasionData)ViewState["MegaCasionData"];
              }
            else
            {

                casionData.balanceAmount = 100;
                casionData.betAmount = 5;
                casionData.winningAmount = 0;

                casionData.slotImage1int = 10;
                casionData.slotImage2int = 10;
                casionData.slotImage3int = 10;

                PopulateData();

                ViewState["MegaCasionData"] = casionData;


               // List<SpyClass> spyList = new List<SpyClass>();
               //ViewState.Add("SpyListValue", spyList);
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Populate data
            PopulateData();

            // check if bet can be made (bet > 0) (bet < balance) (check if textbox has double value)
            if (!CanWeBet())
                return;

            // pick three random numbers out of 12
            CreateRandomNumbers();

            // display new numbers
            SetSlotImages();

            // minus bet from betting total
            SubmitBet();

            // check for cherries 
            CheckForCherries();

            // check for 7's
            CheckForJackPot();

            // check for bar
            CheckForBar();

            //Do the math
            DoTheMath();

            // display winnings/ lose
            DisplayNewInfo();

            //clear winnings amount
            ResetData();

            // save state
            ViewState["MegaCasionData"] = casionData;

            
            

        }

        private void ResetData()
        {
            casionData.winningAmount = 0;
           // casionData.betAmount = 0;
           
        }

        private void DisplayNewInfo()
        {
            winningsLabel.Text = String.Format("You bet {0} and won {1}!",
                casionData.betAmount.ToString("c"),casionData.winningAmount.ToString("c"));

            balanceLabel.Text = (casionData.balanceAmount).ToString("c");




        }

        private void DoTheMath()
        {
            casionData.balanceAmount += casionData.winningAmount; 
        }

        private void CheckForBar()
        {
            if (casionData.slotImage1int == 1 || casionData.slotImage2int == 1 || casionData.slotImage3int == 1)
                casionData.winningAmount = 0;
        }

        private void CheckForJackPot()
        {
            if (casionData.slotImage1int == 10 && casionData.slotImage2int == 10 && casionData.slotImage3int == 10)
                casionData.winningAmount = casionData.betAmount * 100;
        }

        private void CheckForCherries()
        {
            int cherryCount = 0;

            if (casionData.slotImage1int == 3)
                cherryCount = 1;
            if (casionData.slotImage2int == 3)
                cherryCount += 1;
            if (casionData.slotImage3int == 3)
                cherryCount += 3;

            if (cherryCount == 0)
                return;
            if (cherryCount == 1)
                casionData.winningAmount = casionData.betAmount * 2;
            if (cherryCount == 2)
                casionData.winningAmount = casionData.betAmount * 3;
            if (cherryCount == 3)
                casionData.winningAmount = casionData.betAmount * 4;


        }

        private void SubmitBet()
        {
            casionData.balanceAmount -= casionData.betAmount;
        }

        private void CreateRandomNumbers()
        {
            Random random = new Random();
            casionData.slotImage1int = random.Next(1, 13);
            casionData.slotImage2int = random.Next(1, 13);
            casionData.slotImage3int = random.Next(1, 13);

        }

        private bool CanWeBet()
        {
            double betAmount = BetValue();

            casionData.betAmount = betAmount;

            if (betAmount <= 0)
            {
                winningsLabel.Text = "Cant Place a bet with nothing";
                return false;
            }

            if(casionData.balanceAmount <= 0 || (casionData.betAmount > casionData.betAmount))
            {
                winningsLabel.Text = "ERROR";
                return false;
            }


            return true;
        }

        private double BetValue()
        {

            Double.TryParse(betTextBox.Text, out double x);
            
            return x;
        }


        private void PopulateData()
        {
           
           // betTextBox.Text = (casionData.betAmount).ToString();
            balanceLabel.Text = (casionData.balanceAmount).ToString("c");
            winningsLabel.Text = "";

            SetSlotImages();

        }

        private void SetSlotImages()
        {
            slotOneImage.ImageUrl = ReturnImageAddress(casionData.slotImage1int);
            slotTwoImage.ImageUrl = ReturnImageAddress(casionData.slotImage2int);
            slotThreeImage.ImageUrl = ReturnImageAddress(casionData.slotImage3int);

        }

        private String ReturnImageAddress(int x)
        {
            String y = "Lemon.png";

            switch (x)
            {
                case 1:
                    y = "Bar.png";
                    break;
                case 2:
                    y = "Bell.png";
                    break;
                case 3:
                    y = "Cherry.png";
                    break;
                case 4:
                    y = "Clover.png";
                    break;
                case 5:
                    y = "Diamond.png";
                    break;
                case 6:
                    y = "HorseShoe.png";
                    break;
                case 7:
                    y = "Lemon.png";
                    break;
                case 8:
                    y = "Orange.png";
                    break;
                case 9:
                    y = "Plum.png";
                    break;
                case 10:
                    y = "Seven.png";
                    break;
                case 11:
                    y = "Strawberry.png";
                    break;
                case 12:
                    y = "Watermellon.png";
                    break;
            }

            return y;



        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
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

            if (ViewState["MegaCasionData"] != null)
            {
                casionData = (CasionData)ViewState["MegaCasionData"];
              }
            else
            {
                casionData = new CasionData();

                casionData.balanceAmount = 100;
                casionData.betAmount = 5;
                casionData.winningAmount = 0;

                casionData.slotImage1int = 10;
                casionData.slotImage2int = 10;
                casionData.slotImage3int = 10;

               // List<SpyClass> spyList = new List<SpyClass>();
                //ViewState.Add("SpyListValue", spyList);
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Populate data
            PopulateData();

            // display current balance 
            
            // check if bet can be made (bet > 0) (bet < balance) (check if textbox has double value)

            // pick three random numbers out of 12

            // display new numbers

            // check for bar

            // check for cherries 

            // check for 7's

            // save state

            // display winnings/ lose
            
            

        }

        private void PopulateData()
        {
            betTextBox.Text = (casionData.betAmount).ToString();
            balanceLabel.Text = (casionData.balanceAmount).ToString();
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
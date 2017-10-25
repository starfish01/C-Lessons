using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        List<SpyClass> spyList;
        protected void Page_Load(object sender, EventArgs e)
        {

            if(ViewState["SpyListValue"] != null)
            {
                spyList = (List<SpyClass>)ViewState["SpyListValue"];
            } else
            {
                List<SpyClass> spyList = new List<SpyClass>();
                ViewState.Add("SpyListValue", spyList);
            }


        }

        protected void resultButton_Click(object sender, EventArgs e)
        {
            
            spyList = (List<SpyClass>)ViewState["SpyListValue"];

            
            //check name textbox has been filled in not null not whitespace
            if (CheckIfNameSpaceHasBeenFilledIn())
            {
                //create object
                SpyClass newData = GrabData();

                //check if spy already is in list
                InsertNewInformation(newData);

                // display information
                DisplaySpyList();
               

                ViewState["SpyListValue"] = spyList;

            }
            



        }

        private void DisplaySpyList()
        {
            resultLabel.Text = "";

            foreach(var el in spyList)
            {
                resultLabel.Text += el.Name + " Elections Rigged: " + el.ElectionsRigged +
                    " Subterfuge Performed: " + el.SubterfugePerformed;
                resultLabel.Text += "</br>";



            }



        }

        private void InsertNewInformation(SpyClass newData)
        {
            int checkUser = 0;


            foreach(var el in spyList)
            {
                
               if (String.Equals(el.Name, newData.Name))
                {
                    checkUser = 1;
                    el.ElectionsRigged += newData.ElectionsRigged;
                    el.SubterfugePerformed += newData.SubterfugePerformed;

                }
            }

            if(checkUser == 0)
            {
                spyList.Add(newData);

            }

        }

        private SpyClass GrabData()
        {
            int electionsRigged, Subterfuge;
            SpyClass newData = new SpyClass();


            newData.Name = assetNameTextBox.Text;
            int.TryParse(electionsRiggedTextBox.Text, out electionsRigged);
            int.TryParse(subterfugeTextBox.Text, out Subterfuge);

            newData.ElectionsRigged = electionsRigged;
            newData.SubterfugePerformed = Subterfuge;
            
            return newData;
        }

        private bool CheckIfNameSpaceHasBeenFilledIn()
        {
            
            //check name is correct
            if (String.IsNullOrWhiteSpace(assetNameTextBox.Text))
                return false;

            //check textBox has int value
            if (int.TryParse(electionsRiggedTextBox.Text, out int k) || String.IsNullOrEmpty(electionsRiggedTextBox.Text))
            {

            }
            else
            {
                electionsRiggedTextBox.Text = "Please insert a number!";
                return false;
            }

            //check textbox has int value
            if (int.TryParse(subterfugeTextBox.Text, out int l) || String.IsNullOrEmpty(electionsRiggedTextBox.Text))
            {

            }
            else
            {
                subterfugeTextBox.Text = "Please insert a number!";
                return false;
            }

            return true;

        }
    }
}
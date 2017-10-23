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
            if (!IsPostBack)
            {
                spyList = new List<SpyClass>();
            }


        }

        protected void resultButton_Click(object sender, EventArgs e)
        {
            //check name textbox has been filled in not null not whitespace
            if (CheckIfNameSpaceHasBeenFilledIn())
            {
                //create object
                SpyClass newData = GrabData();

                //check if spy already is in list
                InsertNewInformation(newData);

                // display information

            }
            



        }

        private void InsertNewInformation(SpyClass newData)
        {
           int a = spyList.Count(x => x.Name == newData.Name);

            resultLabel.Text = a.ToString();

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
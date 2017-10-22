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
        List<spyClass> spyList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                spyList = new List<spyClass>();
            }


        }

        protected void resultButton_Click(object sender, EventArgs e)
        {
            //check name textbox has been filled in not null not whitespace
            if (CheckIfNameSpaceHasBeenFilledIn())
            {

            }
            //

            //



        }

        private bool CheckIfNameSpaceHasBeenFilledIn()
        {
            //check name is correct
            if (String.IsNullOrWhiteSpace(assetNameTextBox.Text))
                return false;

            //check textBox has int value

            //check textbox has int value



            return true;


        }
    }
}
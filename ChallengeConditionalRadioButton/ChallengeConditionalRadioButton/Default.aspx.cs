using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {

        private String resultLabelText = "You have selected ";
        private RadioButton radioBtnChecked;
        

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            whatRadioButtonIsSelected();
            
        }

        private void whatRadioButtonIsSelected()
        {
           
            if (radioPen.Checked)
            {
                resultLabel.Text = resultLabelText + "Pen.";
                imageResult.ImageUrl = "pen.png";
            }
            else if (radioPencil.Checked)
            {
                resultLabel.Text = resultLabelText + "Pencil.";
                imageResult.ImageUrl = "pencil.png";

            }
            else if (radioPhone.Checked)
            {
                imageResult.ImageUrl = "phone.png";
                resultLabel.Text = resultLabelText + "Phone.";
            }
            else if (radioTablet.Checked)
            {
                imageResult.ImageUrl = "tablet.png";
                resultLabel.Text = resultLabelText + "Tablet.";
            }

        }

       

    }
}
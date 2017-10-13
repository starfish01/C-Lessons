using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge1
{
    public partial class Challenge1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void resultBtn_Click(object sender, EventArgs e)
        {
            String age = ageTextBox.Text;
            String money = moneyTextBox.Text;

            String result = "At " + age + " years old, i would expect you to have more than $" + money + " in your pocket.";

            resultLabel.Text = result;
        }
    }
}
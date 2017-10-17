using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePapaBobsPizza
{
    public partial class Default : System.Web.UI.Page
    {

        double basePrice, crustPrice, ingredientPrice, specialSaving;
        double smallPizza, mediumPizza, largePizza, deepCrust, ingrPepperoni,
            ingrOnion, ingrGreenPeppers, ingrRedPeppers, ingrAnchovies;

        protected void Button1_Click(object sender, EventArgs e)
        {
            //base price 
            basePrice = getBaseCost();
            //thick price
            crustPrice = getCrustPrice();
            //ingerident calc
            ingredientPrice = getIngredientPrice();
            //special application
            specialSaving = getSpecialSaving();
            //total value
            displayTotalCost((basePrice + crustPrice + ingredientPrice) - specialSaving);

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //set prices

            smallPizza = 10;
            mediumPizza = 13;
            largePizza = 16;

            deepCrust = 2;

            ingrPepperoni = 1.5;
            ingrOnion = 0.75;
            ingrGreenPeppers = 0.5;
            ingrRedPeppers = 0.75;
            ingrAnchovies = 2;

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void displayTotalCost(double totalCost)
        {
            resultLabel.Text = totalCost.ToString("C");
        }

        private double getBaseCost()
        {
            if (pizzaSizeSmallCheckBox.Checked)
                return smallPizza;
            else if (pizzaSizeMediumCheckBox.Checked)
                return mediumPizza;
            else if (pizzaSizeLargeCheckBox.Checked)
                return largePizza;


           return 0;
        }

        private double getCrustPrice()
        {
            if (pizzaBaseDeepCheckBox.Checked)
                return deepCrust;
            else
                return 0;
       }

        private double getIngredientPrice()
        {
            double total=0;

            if (ingPepperoniCheckBox.Checked)
                total += ingrPepperoni;
            if (ingOnionsCheckBox.Checked)
                total += ingrOnion;
            if (ingGreenPeppersCheckBox.Checked)
                total += ingrGreenPeppers;
            if (ingRedPeppersCheckBox.Checked)
                total += ingrRedPeppers;
            if (ingAnchoviesCheckBox.Checked)
                total += ingrAnchovies;

            

            return total;
        }

        private double getSpecialSaving()
        {
            if (ingPepperoniCheckBox.Checked && ingGreenPeppersCheckBox.Checked && ingAnchoviesCheckBox.Checked ||
                ingPepperoniCheckBox.Checked && ingRedPeppersCheckBox.Checked && ingOnionsCheckBox.Checked)
                return 2;

            return 0;

        }


    }
}
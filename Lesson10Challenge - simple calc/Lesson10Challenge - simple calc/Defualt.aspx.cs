using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson10Challenge___simple_calc
{
    public partial class Defualt : System.Web.UI.Page
    {

        private double value1, value2;
    


        protected void Page_Load(object sender, EventArgs e)
        {
            value1 = 0;
            value2 = 0;
        }


        protected void setValue1()
        {
            if (!String.IsNullOrWhiteSpace(value1TextBox.Text))
            {
                double value;
                if (Double.TryParse(value1TextBox.Text, out value))
                {
                    value1 = value;
                }else
                    value1 = double.NaN;
            }


        }

        protected void setValue2()
        {
            if (!String.IsNullOrWhiteSpace(value2TextBox.Text))
            {
                double value;
                if (Double.TryParse(value2TextBox.Text, out value))
                {
                    value2 = value;
                }else
                    value2 = double.NaN;
            }

        }

        

        private void setValues()
        {
            setValue1();
            setValue2();
        }

        private Boolean checkIfValuesAreNumbers()
        {
            if(double.IsNaN(value1) || double.IsNaN(value2))
            {
                clearBoxErrorMessage();
                somethingWentWrong();
                return false;
            }

            return true;

        }

        private void clearBoxErrorMessage()
        {
            if (double.IsNaN(value1))
                value1TextBox.Text = "Incorrect Value";
            else
                value2TextBox.Text = "Incorrect Value";
        }

        private void somethingWentWrong()
        {
            resultLabel.Text = "Something Went Wrong";
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            setValues();
            if(checkIfValuesAreNumbers())
                resultLabel.Text = value1.ToString() + " + " + value2.ToString() + " = " + getResult(1).ToString();
        }

        protected void subtractBtn_Click(object sender, EventArgs e)
        {
            setValues();
            if (checkIfValuesAreNumbers())
                resultLabel.Text = value1.ToString() + " - " + value2.ToString() + " = " + getResult(2).ToString();
        }

        protected void muiltplyBtn_Click(object sender, EventArgs e)
        {
            setValues();
            if (checkIfValuesAreNumbers())
                resultLabel.Text = value1.ToString() + " * " + value2.ToString() + " = " + getResult(3).ToString();
        }

        protected void devideBtn_Click(object sender, EventArgs e)
        {
            setValues();
            if (checkIfValuesAreNumbers())
                resultLabel.Text = value1.ToString() + " / " + value2.ToString() + " = " + getResult(4).ToString();
        }

        protected void value1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private double getResult(int i)
        {
            double value;
            switch (i)
            {
                case 1:
                     value = value1 + value2;
                    break;
                case 2:
                    value = value1 - value2;
                    break;
                case 3:
                    value = value1 * value2;
                    break;
                case 4:
                    value = value1 / value2;
                    break;
                default:
                    value = 0;
                    break;

                    
            }

            return value;
        }

    }

}
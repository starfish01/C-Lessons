using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Defualt : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            

            if (!IsPostBack)
            {
                endPreviousCalendar.SelectedDate = endPreviousCalendar.VisibleDate = DateTime.Today;
                startAssignmentCalendar.SelectedDate = startAssignmentCalendar.VisibleDate = DateTime.Today.AddDays(14);
                endNewAssignmentCalendar.SelectedDate = endNewAssignmentCalendar.VisibleDate = DateTime.Today.AddDays(21);
            }
            this.Page.MaintainScrollPositionOnPostBack = true;


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";



            if (checkDateLogic())
                if(checkDataEntries())
                    if (spyUnionDemands())
                    {
                        double missionBudget = costOfMission();
                        displayMessage(missionBudget);

                    }

               
            
            


            
        }

        private bool checkDataEntries()
        {
            int error = 0;
            if (String.IsNullOrWhiteSpace(assignmentNameTextBox.Text))
                error =  1;
            if (String.IsNullOrWhiteSpace(spyCodeNameTextBox.Text))
                error += 2;

            if (error == 0)
                return true;

            


            switch (error)
            {
                case 1:
                    resultLabel.Text = "Error: Spy Name was not filled in!";
                    break;
                case 2:
                    resultLabel.Text = "Error: Spy Assignment was not filled in!";
                    break;
                case 3:
                    resultLabel.Text = "Error: Both Spy name and Spy Assignment were not filled in!";
                    break;

            }


            return false;

        }

        private bool checkDateLogic()
        {
            DateTime date1 = endPreviousCalendar.SelectedDate;
            DateTime date2 = startAssignmentCalendar.SelectedDate;
            DateTime date3 = endNewAssignmentCalendar.SelectedDate;

            if ((date2 > date1) && (date3>date2 ))
                return true;

            endPreviousCalendar.SelectedDate = endPreviousCalendar.VisibleDate = DateTime.Today;
            startAssignmentCalendar.SelectedDate = startAssignmentCalendar.VisibleDate = DateTime.Today.AddDays(14);
            endNewAssignmentCalendar.SelectedDate = endNewAssignmentCalendar.VisibleDate = DateTime.Today.AddDays(21);

            resultLabel.Text = "Date Error, dates reset";



            return false;

        }

        private void displayMessage(double missionBudget)
        {
            String spyName = spyCodeNameTextBox.Text;
            String assignmentName = assignmentNameTextBox.Text;
            String missionBudgetString = missionBudget.ToString("c");

            resultLabel.Text = "Assignment of " + spyName + " to assignment Project: " + assignmentName + " is authorized. Budget total: " + missionBudgetString;
            
        }

        private double costOfMission()
        {

            //days between
            DateTime endDate = endNewAssignmentCalendar.SelectedDate;
            DateTime startDate = startAssignmentCalendar.SelectedDate;

            int daysInbetween = Math.Abs(endDate.Day - startDate.Day);



            //muiltiply 5g a day
            double missionBudget = daysInbetween * 500;

            // greater then 21 days bonus 1g
            if (daysInbetween >= 21)
                missionBudget += 1000;

            return missionBudget;

        }

        private bool spyUnionDemands()
        {
            DateTime endDate = endPreviousCalendar.SelectedDate;
            DateTime startDate = startAssignmentCalendar.SelectedDate;

            int daysInbetween = Math.Abs(endDate.Day - startDate.Day);

            

            // check we are at least 14 days out
            if (daysInbetween >= 14)
                return true;

            //show error message
            resultLabel.Text = "Spies must have two weeks break between operations, The new selected date is the earliest they can start";
            

            //change date to 14 days out highlight date 
            startAssignmentCalendar.SelectedDate = endDate.AddDays(14);

            return false;

        }


        

    }
}
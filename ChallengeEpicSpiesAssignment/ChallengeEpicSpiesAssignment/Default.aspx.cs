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
            if (spyUnionDemands())
            {

            }


            
        }

        private bool spyUnionDemands()
        {
            DateTime endDate = endPreviousCalendar.SelectedDate;
            DateTime startDate = startAssignmentCalendar.SelectedDate;

            int days = Math.Abs(endDate.Day - startDate.Day);

            if (days >= 14)
                return true;

            //show error message

            //change date to 14 days out highlight date 


            return false;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ODL_Bootcamp
{
    public partial class LeapYearDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDispYear_Click(object sender, EventArgs e)
        {
            int yearValue = Convert.ToInt32(txtYear.Text);

            if (yearValue % 400 == 0 || yearValue % 4 == 0)
            {
                lblResult.Text = "Leap Year";
            }
            else
            {
                lblResult.Text = "Not a Leap Year";
            }
        }
    }
}
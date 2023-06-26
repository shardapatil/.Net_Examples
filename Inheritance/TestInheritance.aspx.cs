using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ODL_Bootcamp.BAL;

namespace ODL_Bootcamp
{
    public partial class TestInheritance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisp_Click(object sender, EventArgs e)
        {
            Programmer obj = new Programmer();
            lblSalary.Text = "Salary of the Employee : " + obj.salary.ToString();
            lblBonus.Text = "Bonus of the Employee : " + obj.bonus.ToString();

        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            ClassC obj = new ClassC();
            lblCount.Text = "Count Generated : " + obj.count.ToString();
        }
    }
}
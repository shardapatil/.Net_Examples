using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ODL_Bootcamp
{
    public partial class NumberPatternDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisp_Click(object sender, EventArgs e)
        {
            int val1 = Convert.ToInt32(txtValue.Text);
            for (int i = 1; i <= val1; i++)
            {
                for (int j = 1, k = 1; j <= i; j++)
                {
                    lblResult.Text = lblResult.Text + k++;
                }
                lblResult.Text = lblResult.Text + "<br>";
                //k = k+1;
            }
        }
    }
}

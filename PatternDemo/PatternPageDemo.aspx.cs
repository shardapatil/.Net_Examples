using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ODL_Bootcamp
{
    public partial class PatternPageDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            int ValueEntered = Convert.ToInt32(txtValue.Text);

            for (int i = 0; i <= ValueEntered; i++)
            {
                for (int j = i; j <= ValueEntered; j++)
                {
                   
                    
                    lblResult.Text =lblResult.Text+"*";
                }
                lblResult.Text = lblResult.Text + "<br>";
            }
        }
    }
}
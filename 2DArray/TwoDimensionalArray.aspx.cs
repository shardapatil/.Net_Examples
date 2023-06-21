using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ODL_Bootcamp
{
    public partial class TwoDimensionalArray : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[,] numbers = { { 2, 3, 9 }, { 4, 5, 9 } };

            for (int i = 0; i < numbers.GetLength(0); i++)//rows
            {
                for (int j = 0; j < numbers.GetLength(1); j++) //columns
                {
                    lblResult.Text += numbers[i,j].ToString() + " ";
                    
                }
                lblResult.Text = lblResult.Text + "<br>";
                
            }
        }
    }
}
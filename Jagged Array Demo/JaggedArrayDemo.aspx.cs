using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ODL_Bootcamp
{
    public partial class JaggedArrayDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[][] arr = new int[2][];

            arr[0] = new int[5] { 1, 2, 5, 6, 7 };
            arr[1] = new int[4] { 4, 7, 8, 9 };

            for (int i = 0; i <= arr.GetLength(0); i++)
            {
                for (int j = 0; j <=arr.GetLength(1); j++)
                {
                    lblArrayDisp.Text += (arr[i][j]).ToString();

                }
                lblArrayDisp.Text = lblArrayDisp.Text + "<br>";

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ODL_Bootcamp
{
    public partial class ArrayDemo : System.Web.UI.Page
    {
        string[] intArray = new string[10];
        int n=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["array"] != null)
            {
                intArray = Session["array"] as string[];
                n = Convert.ToInt32(Session["count"]);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            intArray[n++] = txtArray.Text;
            Session["array"] = intArray;
            Session["count"] = n;
           
        }

        protected void btnDisp_Click(object sender, EventArgs e)
        {
            
            foreach (string i in intArray)
            {
                lblResult.Text += i + "<br>";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ODL_Bootcamp
{
    public partial class AjaxDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000);
            lblResult.Text = System.DateTime.Now.ToString();

        }
    }
}
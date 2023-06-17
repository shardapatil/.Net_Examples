using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ODL_Bootcamp
{
    public partial class EnumDemo : System.Web.UI.Page
    {
        enum Months
        {
            January,
            February,
            March=6,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        StringBuilder ListOfMonth = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            //lblEnumDisp.Text = (Convert.ToInt32(Months.April)).ToString();
           // lblEnumDisp.Text = ((int)Months.March).ToString();

           // lblEnumDisp.Text = Enum.GetValues(typeof(Months)).ToString();
            foreach (Months mon in Enum.GetValues(typeof(Months)))
            {
                //int index = (Convert.ToInt32(typeof(Months)));
                int i = (int)mon;
                lblEnumDisp.Text += i.ToString() + " " + mon.ToString() + "<br>"  ;
            }

            //stringbuilder
            foreach (Months m in Enum.GetValues(typeof(Months)))
            {
                ListOfMonth.Append(Convert.ToInt32(m));
                ListOfMonth.Append(" ");
                ListOfMonth.Append(m);
                ListOfMonth.Append("<br>");
                

            }

            lblEnumString.Text = ListOfMonth.ToString();
        }
    }
}
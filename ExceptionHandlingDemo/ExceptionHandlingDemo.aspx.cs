using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ODL_Bootcamp.BAL;

namespace ODL_Bootcamp
{
    public partial class ExceptionHandlingDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtFirstVal.Text);
                int b = Convert.ToInt32(txtSecondVal.Text);

                if (a == 0)
                {
                    //throw new DivideByZeroException();  //anonymous object creation
                    throw new MyException("First Value cant be zero");
                }
                int c = a / b;
                lblException.Text = c.ToString();

            }

            catch (MyException e4)
            {
                lblException.Text = e4.Message;
            }

            catch (DivideByZeroException e1)
            {

                lblException.Text = e1.Message;
            }

            //catch (FormatException e2)
            //{
            //    lblException.Text = e2.Message;
            //}

            catch (Exception e3)
            {
                lblException.Text = e3.Message;
            }
            
        }
    }
}
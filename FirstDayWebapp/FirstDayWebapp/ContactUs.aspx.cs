using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstDayWebapp
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.StringBuilder msg = new System.Text.StringBuilder();
                if (txtName.Text.Length <= 0)
                {
                    msg.Append("Name must be filled in!<br />");
                }
                if (txtEmail.Text.Length <= 0)
                {
                    msg.Append("Email must be filled in!<br />");
                }
                if (txtComments.Text.Length <= 0)
                {
                    msg.Append("Comments must be filled in!<br />");
                }
                if (msg.Length > 0)
                {
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Visible = true;
                    lblError.Text = msg.ToString();
                    throw new Exception("Jason was here!");
                }
                else
                {
                    //submit the form somewhere
                    lblError.Text = "Email sent!<br />";
                    lblError.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception)
            {
                //nothing.
            }
        }
    }
}
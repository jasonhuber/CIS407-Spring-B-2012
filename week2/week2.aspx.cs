using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class week2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGo_Click(object sender, EventArgs e)
    {
        if (txtName.Text.Contains("@"))
        {
            lblOutput.Text = "You cannot enter an @ symbol!";
        }
        else
        {
            lblOutput.Text = txtName.Text;
        }
    }
}
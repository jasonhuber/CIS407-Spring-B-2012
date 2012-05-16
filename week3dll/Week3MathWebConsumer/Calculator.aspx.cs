using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week3MathWebConsumer
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            hub3r.Calc myCalc = new hub3r.Calc();   
//            txtResult.Text = txtNum1.Text + txtNum2.Text;
            txtResult.Text = myCalc.Add(Convert.ToInt16(txtNum1.Text), Convert.ToInt16(txtNum2.Text)).ToString();

        }
    }
}
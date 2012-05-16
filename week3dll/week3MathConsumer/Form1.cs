using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace week3MathConsumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            hub3r.Calc myCalc = new hub3r.Calc();

            //lblResult.Text = (Convert.ToInt16(txtNum1.Text) + Convert.ToInt16(txtNum2.Text)).ToString();
            lblResult.Text = myCalc.Add(Convert.ToInt16(txtNum1.Text), Convert.ToInt16(txtNum2.Text)).ToString();

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                hub3r.Calc myCalc = new hub3r.Calc();

                //lblResult.Text = (Convert.ToInt16(txtNum1.Text) + Convert.ToInt16(txtNum2.Text)).ToString();
                lblResult.Text = myCalc.Divide(Convert.ToInt16(txtNum1.Text), Convert.ToInt16(txtNum2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

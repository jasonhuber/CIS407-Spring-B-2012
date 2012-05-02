using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Day1C_sharpreview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder msg = new StringBuilder();
                if (txtName.Text.Length <= 0)
                {
                    msg.Append("Name must be filled in!\n");
                }
                if (txtEmail.Text.Length <= 0)
                {
                    msg.Append("Email must be filled in!\n");
                }
                if (txtComments.Text.Length <= 0)
                {
                    msg.Append("Comments must be filled in!\n");
                }
                if (msg.Length > 0)
                {
                    MessageBox.Show(msg.ToString());
                    throw new Exception("Jason was here!");
                }
                else
                {
                    //submit the form somewhere
                    MessageBox.Show("The form was emailed!");
                }
            }
            catch (Exception)
            {
                //nothing.
            }
        }
    }
}

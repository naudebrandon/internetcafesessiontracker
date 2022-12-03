using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace TermsAndConditions2
{
    public partial class Form1 : Form
    {

        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNotAccept_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(0, 0);
            //Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            btnAccept.Visible = false;
            btnNotAccept.Visible = false;
            //btnReturn.Visible = true;
            MessageBox.Show("Please make sure to end your session when you are done, by clicking on end session", "Please End Session When Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form2 frm2 = new Form2();
            frm2.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

            /*DialogResult result = MessageBox.Show("Are you sure you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               
            }
            else
            {
                return;
            }*/
        }
    }
}

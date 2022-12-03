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
using System.Drawing.Printing;//For Printing to a Printer
using System.IO;
using System.Management;

namespace TermsAndConditions2
{
    public partial class Form2 : Form
    {
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        string netBiosName;
        String Date;
        String StartTime;
        String EndedTime;

        int ms, s, m, h;
        public Form2()
        {
            InitializeComponent();
            ms = 0;
        }

        private void btnEndSession_Click(object sender, EventArgs e)
        {
            tmrST.Enabled = false;
            EndedTime = DateTime.Now.ToShortTimeString();
            String EndTime=(h + ":" + m + ":" + s);
            GetName();
            //Print PC Name, Time Started, Time ended, Duration
            #region Print Session Data to reciept printer
            for (int i = 0; i < 1; i++)
            {
                //-----------------------------------------------------------------------------------------------------------
                string t = "FotoConnect";
                string r = "Tel: 011 391 2117" + "    " + "Email: fotoconnect2@gmail.com" + "\n" + //--> 
                           "Cnr Mooirivier Rd James Wright Ave, Norkem Park" + "\n" + "\n" +
                           "PC: " + netBiosName + "\n" +
                           "Time Started: " + StartTime + "\n" +
                           "Time Ended: " + EndedTime + "\n" +
                           "Session Duration: " + EndTime;

                //-----------------------------------------------------------------------------------------------------------

                PrintDocument p = new PrintDocument();
                p.PrinterSettings.PrinterName = "EPSON TM-T88IV Receipt";
                p.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
                {
                    e1.Graphics.DrawString(t, new Font("Arial", 15, FontStyle.Bold), new SolidBrush(Color.Black), new
                        RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

                    e1.Graphics.DrawString(r, new Font("Arial", 8), new SolidBrush(Color.Black), new
                        RectangleF(0, 40, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
                };
                try
                {
                    p.Print();
                }
                catch (Exception ex)
                {
                    throw new Exception("An Error Occured While Printing -->", ex);

                }
            }

            #endregion
            //MessageBox.Show("Duration of this session was " + EndTime + '\n' + '\n' + "Please call Attendant", "Session Ended", MessageBoxButtons.OK,MessageBoxIcon.Information);
            ExitWindowsEx(0,0);
            //Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tmrST.Enabled = true;
            Date = DateTime.Now.ToShortDateString();
            StartTime = DateTime.Now.ToShortTimeString();
        }

        private const int WS_SYSMENU = 0X80000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }

        private void tmrST_Tick(object sender, EventArgs e)
        {
            ms = ms + 1;
            if (ms == 9)
            {
                ms = 0;
                s = s + 1;
                lblsecond.Text = s.ToString();
                if (s == 59)
                {
                    s = 0;
                    m = m + 1;
                    lblmin.Text = m.ToString();
                    if (m == 59)
                    {
                        m = 0;
                        h = h + 1;
                        lblHour.Text = h.ToString();
                    }
                }
            }
        }

        private void GetName()
        {
            netBiosName = System.Environment.MachineName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Project
{
    public partial class Invoices : Form
    {

        private static Invoices _instance;


        public static Invoices instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Invoices();
                return _instance;
            }
        }
        public Invoices()
        {
            InitializeComponent();
        }
        public string SPhoneOutputValue
        {
            get { return SPhoneOutput.Text; }
            set { SPhoneOutput.Text = value; }
        }

        public string SNameOutputValue
        {
            get { return SNameOutput.Text; }
            set { SNameOutput.Text = value; }
        }

        public string SDateOutputValue
        {
            get { return dateOutput.Text; }
            set { dateOutput.Text = value; }
        }

        public string SMoneyOutputValue
        {
            get { return moneyOutput.Text; }
            set { moneyOutput.Text = value; }
        }

        public string SMailOutputValue
        {
            get { return SMailOutput.Text; }
            set { SMailOutput.Text = value; }
        }

        public string RPhoneOutputValue
        {
            get { return RPhoneOutput.Text; }
            set { RPhoneOutput.Text = value; }
        }

        public string RNameOutputValue
        {
            get { return RNameOutput.Text; }
            set { RNameOutput.Text = value; }
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryimg;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

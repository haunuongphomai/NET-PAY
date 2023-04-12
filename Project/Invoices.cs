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
using Microsoft.Office.Interop.Excel;
using static System.Net.WebRequestMethods;
using System.Net.Mail;
using System.Net;

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
            System.Drawing.Rectangle pagearea = e.PageBounds;
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
            pnl.DrawToBitmap(memoryimg, new System.Drawing.Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fromAddress = new MailAddress("netpaycompanyvn@gmail.com");
            var toAddress = new MailAddress(acc.Instance.getEmail);
            const string frompass = "hfgzikchagrvpmkm";
            const string subject = "Invoices";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, frompass),
                Timeout = 200000,
                EnableSsl = true,
            };

            Bitmap bmp = new Bitmap(panelPrint.Width, panelPrint.Height);
            panelPrint.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
            MailMessage message = new MailMessage();

            message.From = new MailAddress(fromAddress.Address);
            message.To.Add(toAddress.Address);

            message.Subject = subject;
            message.Body = "Your invoices";

            MemoryStream stream = new MemoryStream();
            bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

            stream.Position = 0;
            Attachment attachment = new Attachment(stream, "picture.jpg");
            message.Attachments.Add(attachment);

            smtp.Send(message);
            stream.Dispose();
        }
    }
}

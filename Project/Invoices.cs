using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Invoices : Form
    {
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.QrCode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class HomePanel : UserControl
    {
        private static HomePanel _instance;
        public static HomePanel instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HomePanel();
                return _instance;
            }
        }
        public HomePanel()
        {
            InitializeComponent();
            getInfor();
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(acc.Instance.getPhone, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            imgQRCode.Image = code.GetGraphic(50);
        }

        public string BalanceValue
        {
            get { return lblBalance.Text; }
            set { lblBalance.Text = value; }
        }

        public void update(String newString)
        {
            lblBalance.Text = newString;
        }

        private String addDot(String a)
        {
            string result = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                result = a[i] + result;
                if ((a.Length - i) % 3 == 0 && i != 0)
                {
                    result = "." + result;
                }
            }
            return result;
        }

        public void getInfor()
        {
            //lblBalance.Text = string.Format("{0:n}", int.Parse(acc.Instance.getBalance)) + " VND";
            lblBalance.Text = addDot(acc.Instance.getBalance);
            lblName.Text = acc.Instance.getUsername;
            lblPhone.Text = acc.Instance.getPhone;
        }
    }
}

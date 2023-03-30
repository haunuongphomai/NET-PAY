using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Windows.Compatibility;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class TransactionPanel : UserControl
    {
        private static int receive;
        private static TransactionPanel _instance;


        public static TransactionPanel instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TransactionPanel();
                return _instance;
            }
        }
        public TransactionPanel()
        {
            InitializeComponent();
        }

        public string TextBoxValue
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }

        Random randos = new Random();
        int otp;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String phone = txtPhone.Text;
                clsDatabase.OpenConnection();
                SqlCommand query = new SqlCommand("select * from users where phone = @phone", clsDatabase.con);
                query.Parameters.AddWithValue("phone", phone);
                var reader = query.ExecuteReader();

                reader.Read();
                if (reader.HasRows)
                {
                    nameOutput.Text = Convert.ToString(reader["username"]);
                    receive = Convert.ToInt32(reader["accBalance"]);

                    lblName.Show();
                    lblMoney.Show();
                    nameOutput.Show();
                    txtMoney.Show();
                    btnEnter.Show();
                    lblOtp.Show();
                    txtOtp.Show();
                    btnOtp.Show();
                    txtOtp.ReadOnly = true;
                    //imgQRCode.Hide();
                    //cboDevice.Hide();

                }
                else
                {
                    MessageBox.Show("No account found!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void TransactionPanel_Load(object sender, EventArgs e)
        {
            lblName.Hide();
            lblMoney.Hide();
            nameOutput.Hide();
            txtMoney.Hide();
            btnEnter.Hide();
            txtOtp.Hide();
            lblOtp.Hide();
            btnOtp.Hide();
            //imgQRCode.Hide();
            //cboDevice.Hide();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtMoney.Text == "")
            {
                MessageBox.Show("Money cannot be empty!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToInt32(acc.Instance.getBalance) < Convert.ToInt32(txtMoney.Text))
            {
                MessageBox.Show("Exceed the current balance!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToInt32(txtOtp.Text) != otp)
            {
                MessageBox.Show("OTP code is incorrect!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                int send = Convert.ToInt32(acc.Instance.getBalance) - Convert.ToInt32(txtMoney.Text);
                acc.Instance.getBalance = Convert.ToString(send);

                receive += Convert.ToInt32(txtMoney.Text);

                clsDatabase.OpenConnection();
                SqlCommand query = new SqlCommand("update users set accBalance = @money where phone = @phone;", clsDatabase.con);
                query.Parameters.AddWithValue("phone", txtPhone.Text);
                query.Parameters.AddWithValue("money", receive);
                query.ExecuteNonQuery();

                SqlCommand query2 = new SqlCommand("update users set accBalance = @money where phone = @phone;", clsDatabase.con);
                query2.Parameters.AddWithValue("phone", acc.Instance.getPhone);
                query2.Parameters.AddWithValue("money", acc.Instance.getBalance);
                query2.ExecuteNonQuery();

                SqlCommand query3 = new SqlCommand("insert into history values (@username1, @phone1, getdate(), 'send', @username1, @receiver, @money), " +
                    "(@username2, @phone2, getDate(), 'receive', @username1, @receiver, @money)", clsDatabase.con);
                query3.Parameters.AddWithValue("username1", acc.Instance.getUsername);
                query3.Parameters.AddWithValue("phone1", acc.Instance.getPhone);
                query3.Parameters.AddWithValue("receiver", nameOutput.Text);
                query3.Parameters.AddWithValue("money", txtMoney.Text);
                query3.Parameters.AddWithValue("username2", nameOutput.Text);
                query3.Parameters.AddWithValue("phone2", txtPhone.Text);

                query3.ExecuteNonQuery();

                MessageBox.Show("Successfully transfered money!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clsDatabase.CloseConnection();
                receive = 0;

                txtOtp.Text = "";
                txtOtp.ReadOnly = true;
            }
        }

        private void btnOtp_Click(object sender, EventArgs e)
        {
            otp = randos.Next(100000, 1000000);
            var fromAddress = new MailAddress("netpaycompanyvn@gmail.com");
            var toAddress = new MailAddress(acc.Instance.getEmail);
            const string frompass = "hfgzikchagrvpmkm";
            const string subject = "OTP code";
            string body = otp.ToString();

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

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            };
            MessageBox.Show("OTP has been sent to your email");

            txtOtp.ReadOnly = false;
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            QRCode h1 = new QRCode();
            h1.Show();
            lblName.Hide();
            lblMoney.Hide();
            nameOutput.Hide();
            txtMoney.Hide();
            btnEnter.Hide();
            txtOtp.Hide();
            lblOtp.Hide();
            btnOtp.Hide();
            txtPhone.Text = "";

        }

    }
}

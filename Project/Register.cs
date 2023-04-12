using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Project
{
    public partial class Register : Form
    {
        int otp;
        Random randos = new Random();
        public Register()
        {
            InitializeComponent();
        }

        private void linkRegistxt_Click(object sender, EventArgs e)
        {

        }

        private void linkLogin_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        public int isGender()
        {
            if (maleInput.Checked)
            {
                return 1;
            }
            else if (femaleInput.Checked)
            {
                return 0;
            }

            return 0;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String name = usernameInput.Text.ToString();
                String pass = passwordInput.Text.ToString();
                String phone = numberPhoneInput.Text.ToString();
                String email = emailInput.Text.ToString();

                int gender = isGender();

                if (!isPhoneMatch(phone) || phone == "")
                {
                    MessageBox.Show("Phone input incorrect!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (name == "")
                {
                    MessageBox.Show("Name cannot be empty!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (pass == "")
                {
                    MessageBox.Show("Password cannot be empty!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!isPass(name, pass))
                {
                    MessageBox.Show("Name and password have already been used!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!isPhone(phone))
                {
                    MessageBox.Show("Phone have already been used!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (email == "")
                {
                    MessageBox.Show("Email cannot be empty!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    getOtp();
                    string value = "";

                    if (InputBox("Dialog Box", "Verify your email?", ref value) == DialogResult.OK)
                    {
                        if (value.ToString().Equals(otp.ToString()))
                        {
                            MessageBox.Show("Success");
                            clsDatabase.OpenConnection();
                            SqlCommand query = new SqlCommand("insert into users values (@username, @phone, @dob, @pass, 15000000, @gender, @email, 0, 1)", clsDatabase.con);
                            query.Parameters.AddWithValue("username", name);
                            query.Parameters.AddWithValue("phone", phone);
                            query.Parameters.AddWithValue("email", email);
                            query.Parameters.AddWithValue("pass", pass);
                            query.Parameters.AddWithValue("gender", gender);
                            query.Parameters.Add("@dob", SqlDbType.Date).Value = dobInput.Value.Date;

                            query.ExecuteNonQuery();

                            getInfor();

                            Home h1 = new Home();
                            h1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect OTP code");
                        }
                    }

                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public void getOtp()
        {
            otp = randos.Next(100000, 1000000);
            var fromAddress = new MailAddress("netpaycompanyvn@gmail.com");
            var toAddress = new MailAddress(emailInput.Text);
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
        }

        public bool isPhone(String phone)
        {
            clsDatabase.OpenConnection();
            SqlCommand query = new SqlCommand("select count(*) from users where phone = @phone", clsDatabase.con);
            query.Parameters.AddWithValue("phone", phone);
            object temp = query.ExecuteScalar();
            int res = Convert.ToInt32(temp);

            if (res > 0)
            {
                return false;
            }
            return true;
        }

        public bool isPhoneMatch(String phone)
        {
            System.Text.RegularExpressions.Regex expr;
            expr = new Regex(@"^(0)?\d{9}$");
            if (expr.IsMatch(phone))
            {
                return true;
            }
            else return false;
        }

        public bool isPass(String username, String pass)
        {
            clsDatabase.OpenConnection();
            SqlCommand query = new SqlCommand("select count(*) from users where pass = @pass and username = @username", clsDatabase.con);
            query.Parameters.AddWithValue("pass", pass);
            query.Parameters.AddWithValue("username", username);

            object temp = query.ExecuteScalar();
            int res = Convert.ToInt32(temp);
            if (res > 0)
            {
                return false;
            }
            return true;

        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 700, 20);
            buttonOk.SetBounds(228, 160, 160, 60);
            buttonCancel.SetBounds(400, 160, 160, 60);

            label.AutoSize = true;
            form.ClientSize = new Size(796, 307);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            value = textBox.Text;
            return dialogResult;
        }

        private void linkLogin_Click_1(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }

        private void getInfor()
        {
            acc.Instance.getUsername = usernameInput.Text;
            acc.Instance.getBalance = "15000000";
            acc.Instance.getPhone = numberPhoneInput.Text;
            acc.Instance.getPassword = passwordInput.Text;
            acc.Instance.getGender = isGender();
            acc.Instance.getEmail = emailInput.Text;
            acc.Instance.getType = "0";
        }
    }
}

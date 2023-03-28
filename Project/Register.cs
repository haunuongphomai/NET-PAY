using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Project
{
    public partial class Register : Form
    {
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

                    clsDatabase.OpenConnection();
                    SqlCommand query = new SqlCommand("insert into users values (@name, @phone, @dob, @pass, 1000000, @gender, @email)", clsDatabase.con);
                    query.Parameters.AddWithValue("name", name);
                    query.Parameters.AddWithValue("pass", pass);
                    query.Parameters.AddWithValue("phone", phone);
                    query.Parameters.Add("@dob", SqlDbType.Date).Value = dobInput.Value.Date;
                    query.Parameters.AddWithValue("gender", gender);
                    query.Parameters.AddWithValue("email", email);

                    acc.Instance.getUsername = usernameInput.Text;
                    acc.Instance.getBalance = "1000000";
                    acc.Instance.getPhone = numberPhoneInput.Text;
                    acc.Instance.getPassword = passwordInput.Text;
                    acc.Instance.getDOB = dobInput.Text;
                    acc.Instance.getGender = gender;
                    acc.Instance.getEmail = emailInput.Text;

                    query.ExecuteNonQuery();

                    clsDatabase.CloseConnection();

                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
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
    }
}

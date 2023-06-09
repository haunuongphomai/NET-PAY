﻿using System.Data.SqlClient;
using System.Diagnostics;
using ZXing;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void getInfor(String username, String pass)
        {
            clsDatabase.OpenConnection();
            SqlCommand query = new SqlCommand("select * from users where username = @username and pass = @pass", clsDatabase.con);
            query.Parameters.AddWithValue("username", username);
            query.Parameters.AddWithValue("pass", pass);

            var reader = query.ExecuteReader();

            reader.Read();
            acc.Instance.getUsername = Convert.ToString(reader["username"]);
            acc.Instance.getBalance = Convert.ToString(reader["accBalance"]);
            acc.Instance.getPhone = Convert.ToString(reader["phone"]);
            acc.Instance.getPassword = Convert.ToString(reader["pass"]);
            acc.Instance.getDOB = Convert.ToString(reader["dob"]);
            acc.Instance.getGender = Convert.ToInt32(reader["gender"]);
            acc.Instance.getEmail = Convert.ToString(reader["email"]);
            acc.Instance.getType = Convert.ToString(reader["accType"]);

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                String username = usernameInput.Text.ToString();
                String password = passwordInput.Text.ToString();

                SqlCommand query = new SqlCommand("select * from users where username = @username and pass = @pass", clsDatabase.con);
                query.Parameters.AddWithValue("username", username);
                query.Parameters.AddWithValue("pass", password);

                var x = query.ExecuteReader();
                x.Read();

                if (x.HasRows)
                {
                    Debug.Print(Convert.ToString(x["active"]));
                    if (Convert.ToString(x["active"]).Equals("1"))
                    {
                        String accType = Convert.ToString(x["accType"]);
                        if (accType.Equals("0"))
                        {
                            getInfor(username, password);
                            Home h = new Home();
                            h.Show();
                            this.Hide();
                        }
                        else
                        {
                            getInfor(username, password);
                            HomeAdmin h1 = new HomeAdmin();
                            h1.Show();
                            this.Hide();
                        }
                    } else
                    {
                        MessageBox.Show("Your account has been blocked!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                clsDatabase.CloseConnection();
            }
            catch (Exception) { }
        }

        private void linkRegister_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }
    }
}

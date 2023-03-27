using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AccountSetting : UserControl
    {

        private static AccountSetting _instance;
        public static AccountSetting instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccountSetting();
                return _instance;
            }
        }
        public AccountSetting()
        {
            InitializeComponent();
            getInfor();
        }

        public void getInfor()
        {
            phoneOutput.Text = acc.Instance.getPhone;
            txtName.Text = acc.Instance.getUsername;
            txtPass.Text = acc.Instance.getPassword;
            moneyOutput.Text = string.Format("{0:n}", double.Parse(acc.Instance.getBalance));
            txtDOB.Text = acc.Instance.getDOB;

            Debug.Print(acc.Instance.getGender.ToString());

            if (acc.Instance.getGender == 1)
            {
                rdMale.Checked = true;
                rdFemale.Checked = false;
            } else if (acc.Instance.getGender == 0)
            {
                rdFemale.Checked = true;
                rdMale.Checked = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int g;
                if (rdMale.Checked)
                {
                    g = 1;
                } else
                {
                    g = 0;
                }
                clsDatabase.OpenConnection();
                SqlCommand query = new SqlCommand("update users set username = @username, pass = @pass, gender = @gender, dob = @dob where phone = @phone", clsDatabase.con);
                query.Parameters.AddWithValue("username", txtName.Text);
                query.Parameters.AddWithValue("pass", txtPass.Text);
                query.Parameters.AddWithValue("phone", phoneOutput.Text);
                query.Parameters.AddWithValue("gender", g);
                query.Parameters.Add("@dob", SqlDbType.Date).Value = txtDOB.Value.Date;

                acc.Instance.getUsername = txtName.Text;
                acc.Instance.getPassword = txtPass.Text;
                acc.Instance.getDOB = txtDOB.Text;
                acc.Instance.getGender = g;

                query.ExecuteNonQuery();
                MessageBox.Show("Succesfully update account!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

            }
        }
    }
}

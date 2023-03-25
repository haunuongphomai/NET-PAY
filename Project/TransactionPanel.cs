using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                }
                else
                {
                    MessageBox.Show("No account found!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
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
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtMoney.Text == "")
            {
                MessageBox.Show("Money cannot be empty!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (Convert.ToInt32(acc.Instance.getBalance) < Convert.ToInt32(txtMoney.Text))
            {
                MessageBox.Show("Exceed the current balance!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
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

                MessageBox.Show("Successfully transfered money!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clsDatabase.CloseConnection();
                receive = 0;
            }
        }
    }
}

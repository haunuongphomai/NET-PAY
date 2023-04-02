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
    public partial class UserList : UserControl
    {
        private static UserList _instance;
        public static UserList instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserList();
                return _instance;
            }
        }
        public UserList()
        {
            InitializeComponent();
            load_Data1();
        }

        public void load_Data1()
        {
            try
            {
                String id = acc.Instance.getUsername;
                clsDatabase.OpenConnection();
                SqlDataAdapter query = new SqlDataAdapter("select * from users where accType not like 1", clsDatabase.con);

                DataTable dtb = new DataTable();
                query.Fill(dtb);

                userTable.DataSource = dtb;
                clsDatabase.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var height = 45;
            foreach (DataGridViewRow dr in userTable.Rows)
            {
                height += dr.Height;
            }

            userTable.Height = height;
        }

        private void userTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (userTable.CurrentRow != null)
            {
                clsDatabase.OpenConnection();
                DataGridViewRow dgvRow = userTable.CurrentRow;
                SqlCommand query = new SqlCommand("update users set username = @username, " +
                    "dob = @dob, " +
                    "pass = @pass, " +
                    "accBalance = @accBalance, " +
                    "gender = @gender, " +
                    "email = @email, " +
                    "active = @active, " +
                    "accType = @accType where phone = @phone", clsDatabase.con);

                query.Parameters.AddWithValue("username", dgvRow.Cells["username"].Value);
                query.Parameters.AddWithValue("dob", dgvRow.Cells["dob"].Value);
                query.Parameters.AddWithValue("pass", dgvRow.Cells["pass"].Value);
                query.Parameters.AddWithValue("accBalance", dgvRow.Cells["accBalance"].Value);
                query.Parameters.AddWithValue("gender", dgvRow.Cells["gender"].Value);
                query.Parameters.AddWithValue("email", dgvRow.Cells["email"].Value);
                query.Parameters.AddWithValue("accType", dgvRow.Cells["accType"].Value);
                query.Parameters.AddWithValue("active", dgvRow.Cells["active"].Value);
                query.Parameters.AddWithValue("phone", dgvRow.Cells["phone"].Value);

                query.ExecuteNonQuery();

                clsDatabase.CloseConnection();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand query = new SqlCommand("delete from users where phone = @phone", clsDatabase.con);
                query.Parameters.AddWithValue("phone", userTable.CurrentRow.Cells["phone"].Value);
                query.ExecuteNonQuery();
                clsDatabase.CloseConnection();
                load_Data1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            String s1 = txtSearch.Text;

            clsDatabase.OpenConnection();
            SqlDataAdapter query = new SqlDataAdapter("select * from users where phone = @phone", clsDatabase.con);
            query.SelectCommand.Parameters.AddWithValue("phone", s1);
            DataTable dtb = new DataTable();
            query.Fill(dtb);

            if (dtb.Rows.Count > 0)
            {
                userTable.DataSource = dtb;
            }
            else
            {
                load_Data1();
            }
            clsDatabase.CloseConnection();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Silver;
            }
        }
    }
}

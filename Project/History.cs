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
    public partial class History : UserControl
    {
        private static History _instance;
        public static History instance
        {
            get
            {
                if (_instance == null)
                    _instance = new History();
                return _instance;
            }
        }
        public History()
        {
            InitializeComponent();
            load_Data1();
            this.historyTable.AllowUserToAddRows = false;
        }

        public void load_Data1()
        {
            try
            {
                String id = acc.Instance.getUsername;
                clsDatabase.OpenConnection();
                SqlDataAdapter query;
                if (id[0].Equals('#'))
                {
                    query = new SqlDataAdapter("select * from history", clsDatabase.con);
                }
                else
                {
                    query = new SqlDataAdapter("select * from history where phone = @phone", clsDatabase.con);
                }

                query.SelectCommand.Parameters.AddWithValue("phone", acc.Instance.getPhone);
                DataTable dtb = new DataTable();
                query.Fill(dtb);

                historyTable.DataSource = dtb;
                clsDatabase.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (historyTable.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                    xcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < historyTable.Columns.Count + 1; i++)
                    {
                        xcelApp.Cells[1, i] = historyTable.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < historyTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < historyTable.Columns.Count; j++)
                        {
                            xcelApp.Cells[i + 2, j + 1] = historyTable.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    xcelApp.Columns.AutoFit();
                    xcelApp.Visible = true;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            String s1 = txtSearch.Text;

            clsDatabase.OpenConnection();
            SqlDataAdapter query = new SqlDataAdapter("select * from history where phone = @phone", clsDatabase.con);
            query.SelectCommand.Parameters.AddWithValue("phone", s1);
            DataTable dtb = new DataTable();
            query.Fill(dtb);

            if (dtb.Rows.Count > 0)
            {
                historyTable.DataSource = dtb;
            }
            else
            {
                load_Data1();
            }
            clsDatabase.CloseConnection();
        }

        private void History_Load(object sender, EventArgs e)
        {
            if (acc.Instance.getType.Equals("1"))
            {
                txtSearch.Show();
            }
            else
            {
                txtSearch.Hide();
            }

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

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        
        String email;
        String RPhone;

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            Invoices h1 = new Invoices();
            h1.SPhoneOutputValue = phone;
            h1.SNameOutputValue = username;
            h1.SDateOutputValue = date;
            h1.RNameOutputValue = receiver;
            h1.SMoneyOutputValue = amount;
            h1.RPhoneOutputValue = phone2;
            h1.SMailOutputValue = mail;
            h1.Show();
        }

        String username;
        String password;
        String phone;
        String phone2;
        String receiver;
        String amount;
        String date;
        String mail;

        public void getInfor(String s1)
        {
            clsDatabase.OpenConnection();
            SqlCommand query = new SqlCommand("select email from users where phone = @phone", clsDatabase.con);
            query.Parameters.AddWithValue("phone", s1);
            object res = query.ExecuteScalar();
            email = res.ToString();

            clsDatabase.CloseConnection();
        }

        private void historyTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (historyTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                getInfor(historyTable.Rows[e.RowIndex].Cells["phone"].FormattedValue.ToString());
                historyTable.CurrentCell.Selected = true;
                phone = historyTable.Rows[e.RowIndex].Cells["phone"].FormattedValue.ToString();
                username = historyTable.Rows[e.RowIndex].Cells["sender"].FormattedValue.ToString();
                date = historyTable.Rows[e.RowIndex].Cells["currDate"].FormattedValue.ToString();
                receiver = historyTable.Rows[e.RowIndex].Cells["receiver"].FormattedValue.ToString();
                amount = historyTable.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
                phone2 = historyTable.Rows[e.RowIndex].Cells["phone2"].FormattedValue.ToString();
                mail = email;
            } 
        }
    }
}

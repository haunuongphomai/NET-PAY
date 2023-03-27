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
                SqlDataAdapter query = new SqlDataAdapter("select * from history where phone = @phone", clsDatabase.con);

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
            } catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}

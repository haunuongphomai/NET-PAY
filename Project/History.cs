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
    }
}

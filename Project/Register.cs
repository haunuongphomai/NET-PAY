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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void username_pn_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, username_pn.ClientRectangle,
            Color.White, 0, ButtonBorderStyle.Solid, // left
            ColorTranslator.FromHtml("#3a3c4f"), 3, ButtonBorderStyle.Solid, // top
            Color.DimGray, 0, ButtonBorderStyle.Solid, // right
            Color.DimGray, 0, ButtonBorderStyle.Solid);// bottom
        }

        private void Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, username_pn.ClientRectangle,
            Color.White, 0, ButtonBorderStyle.Solid, // left
            ColorTranslator.FromHtml("#3a3c4f"), 3, ButtonBorderStyle.Solid, // top
            Color.DimGray, 0, ButtonBorderStyle.Solid, // right
            ColorTranslator.FromHtml("#3a3c4f"), 3, ButtonBorderStyle.Solid);// bottom
        }

        private void p2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String username = userInput.Text;
                String pass = passInput.Text;
                String name = nameInput.Text;
                String dob = dobInput.Text;
                String addr = addrInput.Text;
                String id = "";
                String balance = "";

                clsDatabase.OpenConnection();
                SqlCommand query = new SqlCommand("insert into users values ( " +
                    "@username, @name, @id, @dob, @pass, @addr, @balance)", clsDatabase.con);

                query.Parameters.AddWithValue("username", username);
                query.Parameters.AddWithValue("pass", pass);
                query.Parameters.AddWithValue("name", name);
                query.Parameters.AddWithValue("id", id);
                query.Parameters.AddWithValue("dob", dob);
                query.Parameters.AddWithValue("addr", addr);
                query.Parameters.AddWithValue("balance", balance);

                query.ExecuteNonQuery();

                acc.Instance.getUsername = username;
                acc.Instance.getPassword = pass;

                clsDatabase.CloseConnection();

                Home dt = new Home();
                this.Hide();
                dt.ShowDialog();
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            this.exit.BackColor = System.Drawing.Color.Red;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
        }

        private void forget_Click(object sender, EventArgs e)
        {
            Form1 h1 = new Form1();
            h1.Show();
            this.Hide();
        }
    }
}

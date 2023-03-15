using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void password_pn_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, username_pn.ClientRectangle,
            Color.White, 0, ButtonBorderStyle.Solid, // left
            ColorTranslator.FromHtml("#3a3c4f"), 0, ButtonBorderStyle.Solid, // top
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

                clsDatabase.OpenConnection();
                SqlCommand query = new SqlCommand("select * from users where username = @username and pass = @pass", clsDatabase.con);
                query.Parameters.AddWithValue("username", username);
                query.Parameters.AddWithValue("pass", pass);

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
            Register h1 = new Register();
            h1.Show();
            this.Hide();
        }
    }
}
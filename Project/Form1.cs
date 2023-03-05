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

                clsDatabase.CloseConnection();

                HomePage dt = new HomePage();
                dt.Show();
                this.Hide();

            } catch (Exception)
            {
                MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
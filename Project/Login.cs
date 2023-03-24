using System.Data.SqlClient;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                String username = usernameInput.Text.ToString();
                String password = passwordInput.Text.ToString();

                SqlCommand query = new SqlCommand("select count(*) from users where username = @username and pass = @pass", clsDatabase.con);
                query.Parameters.AddWithValue("username", username);
                query.Parameters.AddWithValue("pass", password);

                object x = query.ExecuteScalar();
                int res = Convert.ToInt32(x);

                clsDatabase.CloseConnection();

                if (res > 0)
                {
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

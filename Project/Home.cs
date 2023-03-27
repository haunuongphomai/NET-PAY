using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Home : Form
    {
        static Home obj;
        private HomePanel myHomePanel = new HomePanel();
        private bool isColapse = false;
        public static Home instnace
        {
            get
            {
                if (obj == null)
                {
                    obj = new Home();
                }
                return obj;
            }
        }

        public Panel Container
        {
            get { return voidPanel; }
            set { voidPanel = value; }
        }
        public Home()
        {
            InitializeComponent();
            panel1.BringToFront();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            obj = this;
            HomePanel home = new HomePanel();
            home.Dock = DockStyle.Fill;
            Container.Controls.Add(home);

            if (search.Text.Length == 0)
            {
                search.Text = "Search";
                search.ForeColor = Color.Silver;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (!voidPanel.Controls.Contains(History.instance))
            {
                voidPanel.Controls.Add(History.instance);
                History.instance.Dock = DockStyle.Fill;
                History.instance.BringToFront();
            }
            else
            {
                History.instance.BringToFront();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            myHomePanel.update(acc.Instance.getBalance);
            Container.Controls["HomePanel"].BringToFront();
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text.Length == 0)
            {
                search.Text = "Search";
                search.ForeColor = Color.Silver;
            }
        }

        private void search_Enter(object sender, EventArgs e)
        {
            if (search.Text == "Search")
            {
                search.Text = "";
                search.ForeColor = Color.Black;
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if (!voidPanel.Controls.Contains(TransactionPanel.instance))
            {
                voidPanel.Controls.Add(TransactionPanel.instance);
                TransactionPanel.instance.Dock = DockStyle.Fill;
                TransactionPanel.instance.BringToFront();
            }
            else
            {
                TransactionPanel.instance.BringToFront();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isColapse)
            {
                panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    isColapse = false;
                }
            }
            else
            {
                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    isColapse = true;
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
            acc.Instance.getUsername = "";
            acc.Instance.getBalance = "";
            acc.Instance.getPhone = "";
            acc.Instance.getPassword = "";
        }

        private void modifAcc_Click(object sender, EventArgs e)
        {
            if (!voidPanel.Controls.Contains(AccountSetting.instance))
            {
                voidPanel.Controls.Add(AccountSetting.instance);
                AccountSetting.instance.Dock = DockStyle.Fill;
                AccountSetting.instance.BringToFront();
            }
            else
            {
                AccountSetting.instance.BringToFront();
            }
        }
    }
}

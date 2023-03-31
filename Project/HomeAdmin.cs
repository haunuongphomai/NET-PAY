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
    public partial class HomeAdmin : Form
    {
        static HomeAdmin obj;
        private HomePanel myHomePanel = new HomePanel();
        private bool isColapse = false;
        public static HomeAdmin instnace
        {
            get
            {
                if (obj == null)
                {
                    obj = new HomeAdmin();
                }
                return obj;
            }
        }
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hi " + acc.Instance.getUsername + ", Welcome to NET PAYPAL!";
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!voidPanel.Controls.Contains(UserList.instance))
            {
                voidPanel.Controls.Add(UserList.instance);
                UserList.instance.Dock = DockStyle.Fill;
                UserList.instance.BringToFront();
            }
            else
            {
                UserList.instance.BringToFront();
            }
        }

        private void accSetting_Click(object sender, EventArgs e)
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

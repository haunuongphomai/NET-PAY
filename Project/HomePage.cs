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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panel2.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;  
            } else
            {
                subMenu.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    }
}

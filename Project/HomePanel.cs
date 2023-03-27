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
    public partial class HomePanel : UserControl
    {
        private static HomePanel _instance;
        public static HomePanel instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HomePanel();
                return _instance;
            }
        }
        public HomePanel()
        {
            InitializeComponent();
            getInfor();
            
        }

        public void update(String newString)
        {
            lblBalance.Text = newString;
        }

        public void getInfor()
        {
            lblBalance.Text = string.Format("{0:n}", double.Parse(acc.Instance.getBalance));
        }
    }
}

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

    }
}
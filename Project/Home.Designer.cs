namespace Project
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.actionBar = new Panel();
            this.btnPanel = new Panel();
            this.header = new Panel();
            this.btnAvatar = new Button();
            this.logo = new PictureBox();
            this.greeting = new Label();
            this.creditCard = new PictureBox();
            this.nameCard = new Label();
            this.visa = new Label();
            this.creditcardBehind = new PictureBox();
            this.seriId = new Label();
            this.accountId = new Label();
            this.accountName = new Label();
            this.startDay = new Label();
            this.cvv = new Label();
            this.balanced = new Label();
            this.name = new Label();
            this.id = new Label();
            this.search = new TextBox();
            this.qrCodeimg = new PictureBox();
            this.qrCode = new Label();
            this.SuspendLayout();
            // 
            // actionBar
            // 
            this.actionBar.BackColor = ColorTranslator.FromHtml("#7D9D9C");
            this.actionBar.Location = new Point(0, 0);
            this.actionBar.Size = new Size(272, 700);
            this.actionBar.Controls.Add(btnPanel);
            this.actionBar.Controls.Add(logo);
            //
            // Panel content button
            //
            this.btnPanel.BackColor = ColorTranslator.FromHtml("#CBE4DE");
            this.btnPanel.Size = new Size(272, 502);
            this.btnPanel.Location = new Point(0, 198);
            //
            // Header
            //
            this.header.BackColor = ColorTranslator.FromHtml("#222831");
            this.header.Size = new Size(984, 58);
            this.header.Location = new Point(272, 0);
            this.header.Controls.Add(greeting);
            this.header.Controls.Add(btnAvatar);
            this.header.Controls.Add(search);
            //
            // btnAvatar
            //
            this.btnAvatar.Size = new Size(50, 50);
            this.btnAvatar.Location = new Point(10, 4);
            this.btnAvatar.FlatStyle = FlatStyle.Flat;
            this.btnAvatar.FlatAppearance.BorderSize = 0;
            this.btnAvatar.BackColor = Color.Transparent;
            Image image = Properties.Resources.avatar;
            this.btnAvatar.Image = image;
            //
            // Logo
            //
            this.logo.SizeMode = PictureBoxSizeMode.AutoSize;
            this.logo.BackColor = Color.Transparent;
            this.logo.Location = new Point(36, 50);
            this.logo.Image = Properties.Resources.logo;
            //
            // Greeting
            //
            this.greeting.AutoSize = true;
            this.greeting.Text = "Hi Hao, Welcome to NET PAYPAL!";
            this.greeting.Font = new Font("Bahnschrift", 16);
            this.greeting.Location = new Point(60, 15);
            this.greeting.ForeColor = Color.White;
            this.greeting.BackColor = Color.Transparent;
            //
            // Credit card
            //
            this.creditCard.SizeMode = PictureBoxSizeMode.AutoSize;
            this.creditCard.BackColor = ColorTranslator.FromHtml("#393E46");
            this.creditCard.Location = new Point(300, 100);
            this.creditCard.Image = Properties.Resources.creditcard;
            this.creditCard.Controls.Add(nameCard);
            this.creditCard.Controls.Add(visa);
            //
            // Name of credit card
            //
            this.nameCard.Text = "NET PAYPAL";
            this.nameCard.AutoSize = true;
            this.nameCard.Font = new Font("Bahnschrift", 13, FontStyle.Bold);
            this.nameCard.ForeColor = Color.White;
            this.nameCard.Location = new Point(10, 10);
            this.nameCard.BackColor = Color.Transparent;
            //
            // Visa
            //
            this.visa.Text = "VISA";
            this.visa.AutoSize = true;
            this.visa.Font = new Font("Bahnschrift", 15, FontStyle.Bold);
            this.visa.ForeColor = Color.White;
            this.visa.Location = new Point(355, 200);
            this.visa.BackColor = Color.Transparent;
            //
            // Credit card behind
            //
            this.creditcardBehind.SizeMode = PictureBoxSizeMode.AutoSize;
            this.creditcardBehind.BackColor = ColorTranslator.FromHtml("#393E46");
            this.creditcardBehind.Location = new Point(815, 100);
            this.creditcardBehind.Image = Properties.Resources.creditcard;
            this.creditcardBehind.Controls.Add(this.seriId);
            this.creditcardBehind.Controls.Add(this.accountId);
            this.creditcardBehind.Controls.Add(this.accountName);
            this.creditcardBehind.Controls.Add(this.startDay);
            this.creditcardBehind.Controls.Add(this.cvv);
            //
            // Seri into credit card
            //
            this.seriId.Size = new Size(412, 38);
            this.seriId.BackColor = ColorTranslator.FromHtml("#D9D9D9");
            this.seriId.Location = new Point(0, 50);
            //
            // Account ID
            //
            this.accountId.AutoSize = true;
            this.accountId.Text = "Account ID:";
            this.accountId.Location = new Point(10, 100);
            this.accountId.BackColor = Color.Transparent;
            this.accountId.ForeColor = Color.White;
            this.accountId.Font = new Font("Bahnschrift", 12, FontStyle.Italic);
            //
            // Account name
            //
            this.accountName.AutoSize = true;
            this.accountName.Text = "Name:";
            this.accountName.Location = new Point(10, 130);
            this.accountName.BackColor = Color.Transparent;
            this.accountName.ForeColor = Color.White;
            this.accountName.Font = new Font("Bahnschrift", 12, FontStyle.Bold);
            //
            // Start day
            //
            this.startDay.AutoSize = true;
            this.startDay.Text = "Expired" + Environment.NewLine
                + "End:";
            this.startDay.Location = new Point(10, 180);
            this.startDay.BackColor = Color.Transparent;
            this.startDay.ForeColor = Color.White;
            this.startDay.Font = new Font("Bahnschrift", 8, FontStyle.Bold);
            //
            // CVV
            //
            this.cvv.AutoSize = true;
            this.cvv.Text = "CVV:";
            this.cvv.Location = new Point(150, 190);
            this.cvv.BackColor = Color.Transparent;
            this.cvv.ForeColor = Color.White;
            this.cvv.Font = new Font("Bahnschrift", 8, FontStyle.Italic);
            //
            // Balanced
            //
            this.balanced.AutoSize = true;
            this.balanced.Text = "Balanced:";
            this.balanced.Location = new Point(300, 400);
            this.balanced.BackColor = Color.Transparent;
            this.balanced.ForeColor = Color.White;
            this.balanced.Font = new Font("Bahnschrift", 20, FontStyle.Bold);
            //
            // Name
            //
            this.name.AutoSize = true;
            this.name.Text = "Name:";
            this.name.Location = new Point(300, 480);
            this.name.BackColor = Color.Transparent;
            this.name.ForeColor = Color.White;
            this.name.Font = new Font("Bahnschrift", 20, FontStyle.Bold);
            //
            // ID
            //
            this.id.AutoSize = true;
            this.id.Text = "Account ID:";
            this.id.Location = new Point(300, 560);
            this.id.BackColor = Color.Transparent;
            this.id.ForeColor = Color.White;
            this.id.Font = new Font("Bahnschrift", 20, FontStyle.Bold);
            //
            // Search field
            //
            this.search.Text = "Search";
            this.search.ForeColor = ColorTranslator.FromHtml("#999999");
            this.search.Size = new Size(350, 100);
            this.search.Location = new Point(605, 15);
            this.search.Font = new Font("Bahnschrift", 13);
            //
            // QR Code image
            //
            this.qrCodeimg.Size = new Size(230, 230);
            this.qrCodeimg.BackColor = Color.White;
            this.qrCodeimg.Location = new Point(815, 380);
            this.qrCodeimg.Image = Properties.Resources.qrcode;
            //
            // QR Code
            // 
            this.qrCode.AutoSize = true;
            this.qrCode.Text = "Your QR Code";
            this.qrCode.Location = new Point(840, 630);
            this.qrCode.ForeColor = Color.White;
            this.qrCode.Font = new Font("Bahnschrift", 20);

            // Home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = ColorTranslator.FromHtml("#393E46");
            this.ClientSize = new System.Drawing.Size(1256, 700);
            this.Controls.Add(this.actionBar);
            this.Controls.Add(this.header);
            this.Controls.Add(this.creditCard);
            this.Controls.Add(this.creditcardBehind);
            this.Controls.Add(this.balanced);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.qrCodeimg);
            this.Controls.Add(this.qrCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Text = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);


        }

        private Panel actionBar;
        private Panel btnPanel;
        private Panel header;
        private Button btnAvatar;
        private PictureBox logo;
        private Label greeting;
        private PictureBox creditCard;
        private Label nameCard;
        private Label visa;
        private PictureBox creditcardBehind;
        private Label seriId;
        private Label accountId;
        private Label accountName;
        private Label startDay;
        private Label cvv;
        private Label balanced;
        private Label name;
        private Label id;
        private TextBox search;
        private PictureBox qrCodeimg;
        private Label qrCode;

        #endregion
    }
}
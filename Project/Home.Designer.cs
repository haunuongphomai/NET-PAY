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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            actionBar = new Panel();
            btnPanel = new Panel();
            btnTransaction = new Button();
            btnHistory = new Button();
            btnExit = new Button();
            btnHome = new Button();
            modifAcc = new Button();
            logo = new PictureBox();
            btnLogOut = new Button();
            header = new Panel();
            button1 = new Button();
            lblGreeting = new Label();
            voidPanel = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            actionBar.SuspendLayout();
            btnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // actionBar
            // 
            actionBar.BackColor = Color.FromArgb(125, 157, 156);
            actionBar.Controls.Add(btnPanel);
            actionBar.Controls.Add(logo);
            actionBar.Location = new Point(0, 0);
            actionBar.Name = "actionBar";
            actionBar.Size = new Size(272, 700);
            actionBar.TabIndex = 0;
            // 
            // btnPanel
            // 
            btnPanel.BackColor = Color.FromArgb(125, 157, 156);
            btnPanel.Controls.Add(btnTransaction);
            btnPanel.Controls.Add(btnHistory);
            btnPanel.Controls.Add(btnExit);
            btnPanel.Controls.Add(btnHome);
            btnPanel.Controls.Add(modifAcc);
            btnPanel.Location = new Point(0, 198);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(272, 502);
            btnPanel.TabIndex = 0;
            // 
            // btnTransaction
            // 
            btnTransaction.BackColor = Color.Transparent;
            btnTransaction.FlatAppearance.BorderSize = 0;
            btnTransaction.FlatStyle = FlatStyle.Flat;
            btnTransaction.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransaction.Image = (Image)resources.GetObject("btnTransaction.Image");
            btnTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaction.Location = new Point(0, 80);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Padding = new Padding(30, 0, 0, 0);
            btnTransaction.Size = new Size(272, 80);
            btnTransaction.TabIndex = 3;
            btnTransaction.Text = "Transaction";
            btnTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransaction.UseVisualStyleBackColor = false;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.Transparent;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(0, 240);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(30, 0, 0, 0);
            btnHistory.Size = new Size(272, 80);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "History";
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnTest_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 320);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(30, 0, 0, 0);
            btnExit.Size = new Size(272, 80);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(30, 0, 0, 0);
            btnHome.Size = new Size(272, 80);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // modifAcc
            // 
            modifAcc.BackColor = Color.Transparent;
            modifAcc.FlatAppearance.BorderSize = 0;
            modifAcc.FlatStyle = FlatStyle.Flat;
            modifAcc.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            modifAcc.Image = (Image)resources.GetObject("modifAcc.Image");
            modifAcc.ImageAlign = ContentAlignment.MiddleLeft;
            modifAcc.Location = new Point(0, 160);
            modifAcc.Name = "modifAcc";
            modifAcc.Padding = new Padding(30, 0, 0, 0);
            modifAcc.Size = new Size(272, 80);
            modifAcc.TabIndex = 5;
            modifAcc.Text = "Account ";
            modifAcc.TextImageRelation = TextImageRelation.ImageBeforeText;
            modifAcc.UseVisualStyleBackColor = false;
            modifAcc.Click += modifAcc_Click;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BorderStyle = BorderStyle.FixedSingle;
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(0, 0);
            logo.Name = "logo";
            logo.Size = new Size(273, 195);
            logo.SizeMode = PictureBoxSizeMode.CenterImage;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = SystemColors.ButtonHighlight;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleRight;
            btnLogOut.Location = new Point(898, 3);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(83, 50);
            btnLogOut.TabIndex = 6;
            btnLogOut.TabStop = false;
            btnLogOut.Text = "Logout";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // header
            // 
            header.BackColor = Color.Black;
            header.Controls.Add(button1);
            header.Controls.Add(lblGreeting);
            header.Controls.Add(btnLogOut);
            header.Location = new Point(272, 0);
            header.Name = "header";
            header.Size = new Size(984, 58);
            header.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.avatar;
            button1.Location = new Point(6, 3);
            button1.Name = "button1";
            button1.Size = new Size(63, 55);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.BackColor = Color.Transparent;
            lblGreeting.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblGreeting.ForeColor = Color.White;
            lblGreeting.Location = new Point(75, 15);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(0, 27);
            lblGreeting.TabIndex = 0;
            // 
            // voidPanel
            // 
            voidPanel.BackColor = Color.White;
            voidPanel.ImeMode = ImeMode.Katakana;
            voidPanel.Location = new Point(272, 58);
            voidPanel.Name = "voidPanel";
            voidPanel.Size = new Size(984, 642);
            voidPanel.TabIndex = 2;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(1256, 700);
            Controls.Add(voidPanel);
            Controls.Add(actionBar);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            actionBar.ResumeLayout(false);
            btnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
        }

        private Panel actionBar;
        private Panel btnPanel;
        private Panel header;
        private PictureBox logo;
        private Label lblGreeting;

        #endregion
        private Button btnHome;
        private Button btnHistory;
        private Button btnExit;
        private Panel voidPanel;
        private Button btnTransaction;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button modifAcc;
        private Button btnLogOut;
    }
}
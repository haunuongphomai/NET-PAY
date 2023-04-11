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
            actionBar = new Panel();
            btnPanel = new Panel();
            btnLogOut = new Button();
            btnTransaction = new Button();
            btnHistory = new Button();
            btnExit = new Button();
            btnHome = new Button();
            logo = new PictureBox();
            header = new Panel();
            button1 = new Button();
            lblGreeting = new Label();
            voidPanel = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
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
            btnPanel.BackColor = Color.FromArgb(203, 228, 222);
            btnPanel.Controls.Add(button2);
            btnPanel.Controls.Add(btnLogOut);
            btnPanel.Controls.Add(btnTransaction);
            btnPanel.Controls.Add(btnHistory);
            btnPanel.Controls.Add(btnExit);
            btnPanel.Controls.Add(btnHome);
            btnPanel.Location = new Point(0, 198);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(272, 502);
            btnPanel.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(0, 229);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(272, 60);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnTransaction
            // 
            btnTransaction.Location = new Point(0, 55);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(272, 60);
            btnTransaction.TabIndex = 3;
            btnTransaction.Text = "Transaction";
            btnTransaction.UseVisualStyleBackColor = true;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(1, 114);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(272, 60);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnTest_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(83, 444);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(272, 60);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(36, 50);
            logo.Name = "logo";
            logo.Size = new Size(200, 78);
            logo.SizeMode = PictureBoxSizeMode.AutoSize;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(34, 40, 49);
            header.Controls.Add(button1);
            header.Controls.Add(lblGreeting);
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
            voidPanel.ImeMode = ImeMode.Katakana;
            voidPanel.Location = new Point(272, 58);
            voidPanel.Name = "voidPanel";
            voidPanel.Size = new Size(984, 642);
            voidPanel.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Location = new Point(1, 171);
            button2.Name = "button2";
            button2.Size = new Size(272, 60);
            button2.TabIndex = 7;
            button2.Text = "Account";
            button2.UseVisualStyleBackColor = true;
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
            actionBar.PerformLayout();
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
        private Button btnLogOut;
        private Button button2;
    }
}
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
            button2 = new Button();
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
            actionBar.Margin = new Padding(4, 4, 4, 4);
            actionBar.Name = "actionBar";
            actionBar.Size = new Size(340, 875);
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
            btnPanel.Location = new Point(0, 248);
            btnPanel.Margin = new Padding(4, 4, 4, 4);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(340, 628);
            btnPanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(1, 214);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(340, 75);
            button2.TabIndex = 7;
            button2.Text = "Account";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(0, 286);
            btnLogOut.Margin = new Padding(4, 4, 4, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(340, 75);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnTransaction
            // 
            btnTransaction.Location = new Point(0, 69);
            btnTransaction.Margin = new Padding(4, 4, 4, 4);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(340, 75);
            btnTransaction.TabIndex = 3;
            btnTransaction.Text = "Transaction";
            btnTransaction.UseVisualStyleBackColor = true;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(1, 142);
            btnHistory.Margin = new Padding(4, 4, 4, 4);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(340, 75);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnTest_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(104, 555);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 36);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(4, 4, 4, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(340, 75);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(45, 62);
            logo.Margin = new Padding(4, 4, 4, 4);
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
            header.Location = new Point(340, 0);
            header.Margin = new Padding(4, 4, 4, 4);
            header.Name = "header";
            header.Size = new Size(1230, 72);
            header.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.avatar;
            button1.Location = new Point(8, 4);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(79, 69);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.BackColor = Color.Transparent;
            lblGreeting.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblGreeting.ForeColor = Color.White;
            lblGreeting.Location = new Point(94, 19);
            lblGreeting.Margin = new Padding(4, 0, 4, 0);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(0, 33);
            lblGreeting.TabIndex = 0;
            // 
            // voidPanel
            // 
            voidPanel.ImeMode = ImeMode.Katakana;
            voidPanel.Location = new Point(340, 72);
            voidPanel.Margin = new Padding(4, 4, 4, 4);
            voidPanel.Name = "voidPanel";
            voidPanel.Size = new Size(1230, 802);
            voidPanel.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(1570, 875);
            Controls.Add(voidPanel);
            Controls.Add(actionBar);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
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
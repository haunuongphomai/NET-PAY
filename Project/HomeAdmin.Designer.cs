namespace Project
{
    partial class HomeAdmin
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
            btnHistory = new Button();
            accSetting = new Button();
            btnExit = new Button();
            btnUsers = new Button();
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
            actionBar.Name = "actionBar";
            actionBar.Size = new Size(272, 700);
            actionBar.TabIndex = 0;
            // 
            // btnPanel
            // 
            btnPanel.BackColor = Color.FromArgb(203, 228, 222);
            btnPanel.Controls.Add(btnHistory);
            btnPanel.Controls.Add(accSetting);
            btnPanel.Controls.Add(btnExit);
            btnPanel.Controls.Add(btnUsers);
            btnPanel.Location = new Point(0, 198);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(272, 502);
            btnPanel.TabIndex = 0;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(83, 157);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(94, 29);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // accSetting
            // 
            accSetting.Location = new Point(67, 92);
            accSetting.Name = "accSetting";
            accSetting.Size = new Size(126, 29);
            accSetting.TabIndex = 2;
            accSetting.Text = "Account Setting";
            accSetting.UseVisualStyleBackColor = true;
            accSetting.Click += accSetting_Click;
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
            // btnUsers
            // 
            btnUsers.Location = new Point(83, 32);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(94, 29);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
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
            lblGreeting.Size = new Size(364, 33);
            lblGreeting.TabIndex = 0;
            lblGreeting.Text = "Hi , Welcome to NET PAYPAL!";
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
            // 
            // HomeAdmin
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(1256, 700);
            Controls.Add(voidPanel);
            Controls.Add(actionBar);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += HomeAdmin_Load;
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
        private Button btnUsers;
        private Button btnExit;
        private Panel voidPanel;
        private System.Windows.Forms.Timer timer1;
        private Button button1;

        #region Windows Form Designer generated code

        #endregion

        private Button accSetting;
        private Button btnHistory;
    }
}
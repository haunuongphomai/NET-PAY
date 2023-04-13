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
            logo = new PictureBox();
            voidPanel = new Panel();
            btnPanel = new Panel();
            btnHistory = new Button();
            accSetting = new Button();
            btnExit = new Button();
            btnUsers = new Button();
            header = new Panel();
            button1 = new Button();
            lblGreeting = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            actionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            btnPanel.SuspendLayout();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // actionBar
            // 
            actionBar.BackColor = Color.FromArgb(125, 157, 156);
            actionBar.Controls.Add(logo);
            actionBar.Location = new Point(0, 0);
            actionBar.Margin = new Padding(2);
            actionBar.Name = "actionBar";
            actionBar.Size = new Size(273, 195);
            actionBar.TabIndex = 0;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(39, 40);
            logo.Margin = new Padding(2);
            logo.Name = "logo";
            logo.Size = new Size(200, 78);
            logo.SizeMode = PictureBoxSizeMode.AutoSize;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // voidPanel
            // 
            voidPanel.ImeMode = ImeMode.Katakana;
            voidPanel.Location = new Point(273, 55);
            voidPanel.Margin = new Padding(2);
            voidPanel.Name = "voidPanel";
            voidPanel.Size = new Size(984, 642);
            voidPanel.TabIndex = 2;
            // 
            // btnPanel
            // 
            btnPanel.BackColor = Color.FromArgb(203, 228, 222);
            btnPanel.Controls.Add(btnHistory);
            btnPanel.Controls.Add(accSetting);
            btnPanel.Controls.Add(btnExit);
            btnPanel.Controls.Add(btnUsers);
            btnPanel.Location = new Point(1, 195);
            btnPanel.Margin = new Padding(2);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(272, 502);
            btnPanel.TabIndex = 0;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(0, 160);
            btnHistory.Margin = new Padding(2);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(272, 80);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // accSetting
            // 
            accSetting.Location = new Point(0, 80);
            accSetting.Margin = new Padding(2);
            accSetting.Name = "accSetting";
            accSetting.Size = new Size(272, 80);
            accSetting.TabIndex = 2;
            accSetting.Text = "Account Setting";
            accSetting.UseVisualStyleBackColor = true;
            accSetting.Click += accSetting_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(0, 240);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(272, 80);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(0, 0);
            btnUsers.Margin = new Padding(2);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(272, 80);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(34, 40, 49);
            header.Controls.Add(button1);
            header.Controls.Add(lblGreeting);
            header.Location = new Point(273, 0);
            header.Margin = new Padding(2);
            header.Name = "header";
            header.Size = new Size(984, 53);
            header.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.avatar;
            button1.Location = new Point(5, 2);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(51, 44);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.BackColor = Color.Transparent;
            lblGreeting.Font = new Font("Bahnschrift", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblGreeting.ForeColor = Color.White;
            lblGreeting.Location = new Point(60, 12);
            lblGreeting.Margin = new Padding(2, 0, 2, 0);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(245, 27);
            lblGreeting.TabIndex = 0;
            lblGreeting.Text = "Hi , This is ADMIN page!";
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
            Controls.Add(btnPanel);
            Controls.Add(voidPanel);
            Controls.Add(header);
            Controls.Add(actionBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "HomeAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += HomeAdmin_Load;
            actionBar.ResumeLayout(false);
            actionBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            btnPanel.ResumeLayout(false);
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
        private Panel voidPanel;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button btnHistory;
        private Button accSetting;
        private Button btnExit;
        private Button btnUsers;
    }
}
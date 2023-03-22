namespace Project
{
    partial class Login
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
            leftSide = new Panel();
            logo = new PictureBox();
            loginTxt = new Label();
            usernameTxt = new Label();
            username = new TextBox();
            passwdTxt = new Label();
            passwd = new TextBox();
            leftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // leftSide
            // 
            leftSide.BackColor = Color.FromArgb(125, 157, 156);
            leftSide.Controls.Add(logo);
            leftSide.Location = new Point(0, 0);
            leftSide.Name = "leftSide";
            leftSide.Size = new Size(400, 500);
            leftSide.TabIndex = 0;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(100, 200);
            logo.Name = "logo";
            logo.Size = new Size(200, 78);
            logo.SizeMode = PictureBoxSizeMode.AutoSize;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // loginTxt
            // 
            loginTxt.AutoSize = true;
            loginTxt.Font = new Font("Bahnschrift", 25F, FontStyle.Bold, GraphicsUnit.Point);
            loginTxt.ForeColor = Color.White;
            loginTxt.Location = new Point(544, 50);
            loginTxt.Name = "loginTxt";
            loginTxt.TabIndex = 1;
            loginTxt.Text = "LOGIN";
            // 
            // usernameTxt
            // 
            usernameTxt.AutoSize = true;
            usernameTxt.Font = new Font("Bahnschrift", 15F, FontStyle.Italic, GraphicsUnit.Point);
            usernameTxt.ForeColor = Color.FromArgb(125, 157, 156);
            usernameTxt.Location = new Point(440, 160);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Text = "Username:";
            usernameTxt.TabIndex = 2;
            // 
            // username
            // 
            username.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(450, 200);
            username.Name = "username";
            username.Size = new Size(300, 32);
            username.TabStop = false;
            username.TabIndex = 3;
            // 
            // passwordTxt
            // 
            passwdTxt.AutoSize = true;
            passwdTxt.Font = new Font("Bahnschrift", 15F, FontStyle.Italic, GraphicsUnit.Point);
            passwdTxt.ForeColor = Color.FromArgb(125, 157, 156);
            passwdTxt.Location = new Point(440, 250);
            passwdTxt.Name = "passwdTxt";
            passwdTxt.Text = "Password:";
            passwdTxt.TabIndex = 2;
            // 
            // password
            // 
            passwd.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwd.Location = new Point(450, 290);
            passwd.Name = "passwd";
            passwd.Size = new Size(300, 32);
            passwd.TabStop = false;
            passwd.TabIndex = 3;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(800, 500);
            Controls.Add(leftSide);
            Controls.Add(loginTxt);
            Controls.Add(usernameTxt);
            Controls.Add(username);
            Controls.Add(passwdTxt);
            Controls.Add(passwd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            leftSide.ResumeLayout(false);
            leftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel leftSide;
        private PictureBox logo;
        private Label loginTxt;
        private Label usernameTxt;
        private TextBox username;
        private Label passwdTxt;
        private TextBox passwd;
    }
}
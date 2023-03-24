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
            usernameInput = new TextBox();
            passwdTxt = new Label();
            passwordInput = new TextBox();
            loginBtn = new Button();
            linkRegistxt = new Label();
            linkRegister = new Label();
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
            loginTxt.Size = new Size(112, 41);
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
            usernameTxt.Size = new Size(108, 24);
            usernameTxt.TabIndex = 2;
            usernameTxt.Text = "Username:";
            // 
            // usernameInput
            // 
            usernameInput.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usernameInput.Location = new Point(450, 200);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(300, 32);
            usernameInput.TabIndex = 3;
            usernameInput.TabStop = false;
            // 
            // passwdTxt
            // 
            passwdTxt.AutoSize = true;
            passwdTxt.Font = new Font("Bahnschrift", 15F, FontStyle.Italic, GraphicsUnit.Point);
            passwdTxt.ForeColor = Color.FromArgb(125, 157, 156);
            passwdTxt.Location = new Point(440, 250);
            passwdTxt.Name = "passwdTxt";
            passwdTxt.Size = new Size(104, 24);
            passwdTxt.TabIndex = 2;
            passwdTxt.Text = "Password:";
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordInput.Location = new Point(450, 290);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(300, 32);
            passwordInput.TabIndex = 3;
            passwordInput.TabStop = false;
            passwordInput.PasswordChar = '*';
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(48, 227, 202);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(550, 380);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(100, 40);
            loginBtn.TabIndex = 4;
            loginBtn.TabStop = false;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // linkRegistxt
            // 
            linkRegistxt.AutoSize = true;
            linkRegistxt.Font = new Font("Bahnschrift", 9F, FontStyle.Italic, GraphicsUnit.Point);
            linkRegistxt.ForeColor = Color.White;
            linkRegistxt.Location = new Point(575, 330);
            linkRegistxt.Name = "linkRegistxt";
            linkRegistxt.Size = new Size(133, 14);
            linkRegistxt.TabIndex = 5;
            linkRegistxt.Text = "Don't have account yet?";
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Bahnschrift", 9F, FontStyle.Underline, GraphicsUnit.Point);
            linkRegister.ForeColor = Color.White;
            linkRegister.Location = new Point(705, 330);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(51, 14);
            linkRegister.TabIndex = 6;
            linkRegister.Text = "Register";
            linkRegister.Click += linkRegister_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(800, 500);
            Controls.Add(leftSide);
            Controls.Add(loginTxt);
            Controls.Add(usernameTxt);
            Controls.Add(usernameInput);
            Controls.Add(passwdTxt);
            Controls.Add(passwordInput);
            Controls.Add(loginBtn);
            Controls.Add(linkRegistxt);
            Controls.Add(linkRegister);
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
        private TextBox usernameInput;
        private Label passwdTxt;
        private TextBox passwordInput;
        private Button loginBtn;
        private Label linkRegistxt;
        private Label linkRegister;

    }
}
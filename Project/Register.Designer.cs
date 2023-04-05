namespace Project
{
    partial class Register
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
            registerTxt = new Label();
            name = new Label();
            usernameInput = new TextBox();
            numberPhone = new Label();
            numberPhoneInput = new TextBox();
            registerBtn = new Button();
            linkLogintxt = new Label();
            linkLogin = new Label();
            password = new Label();
            dobInput = new DateTimePicker();
            dob = new Label();
            gender = new Label();
            maleInput = new RadioButton();
            femaleInput = new RadioButton();
            passwordInput = new TextBox();
            emailInput = new TextBox();
            lblEmail = new Label();
            leftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // leftSide
            // 
            leftSide.BackColor = Color.FromArgb(125, 157, 156);
            leftSide.Controls.Add(logo);
            leftSide.Location = new Point(0, 0);
            leftSide.Margin = new Padding(4);
            leftSide.Name = "leftSide";
            leftSide.Size = new Size(500, 625);
            leftSide.TabIndex = 0;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(125, 250);
            logo.Margin = new Padding(4);
            logo.Name = "logo";
            logo.Size = new Size(200, 78);
            logo.SizeMode = PictureBoxSizeMode.AutoSize;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // registerTxt
            // 
            registerTxt.AutoSize = true;
            registerTxt.Font = new Font("Bahnschrift", 25F, FontStyle.Bold, GraphicsUnit.Point);
            registerTxt.ForeColor = Color.White;
            registerTxt.Location = new Point(649, 9);
            registerTxt.Margin = new Padding(4, 0, 4, 0);
            registerTxt.Name = "registerTxt";
            registerTxt.Size = new Size(212, 51);
            registerTxt.TabIndex = 1;
            registerTxt.Text = "REGISTER";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Bahnschrift", 15F, FontStyle.Italic, GraphicsUnit.Point);
            name.ForeColor = Color.FromArgb(125, 157, 156);
            name.Location = new Point(543, 59);
            name.Margin = new Padding(4, 0, 4, 0);
            name.Name = "name";
            name.Size = new Size(84, 30);
            name.TabIndex = 2;
            name.Text = "Name:";
            // 
            // usernameInput
            // 
            usernameInput.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usernameInput.Location = new Point(555, 96);
            usernameInput.Margin = new Padding(4);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(374, 38);
            usernameInput.TabIndex = 3;
            usernameInput.TabStop = false;
            // 
            // numberPhone
            // 
            numberPhone.AutoSize = true;
            numberPhone.Font = new Font("Bahnschrift", 15F, FontStyle.Italic, GraphicsUnit.Point);
            numberPhone.ForeColor = Color.FromArgb(125, 157, 156);
            numberPhone.Location = new Point(543, 142);
            numberPhone.Margin = new Padding(4, 0, 4, 0);
            numberPhone.Name = "numberPhone";
            numberPhone.Size = new Size(186, 30);
            numberPhone.TabIndex = 2;
            numberPhone.Text = "Number phone:";
            // 
            // numberPhoneInput
            // 
            numberPhoneInput.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numberPhoneInput.Location = new Point(555, 179);
            numberPhoneInput.Margin = new Padding(4);
            numberPhoneInput.Name = "numberPhoneInput";
            numberPhoneInput.Size = new Size(374, 38);
            numberPhoneInput.TabIndex = 3;
            numberPhoneInput.TabStop = false;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(48, 227, 202);
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            registerBtn.Location = new Point(663, 562);
            registerBtn.Margin = new Padding(4);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(125, 50);
            registerBtn.TabIndex = 4;
            registerBtn.TabStop = false;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // linkLogintxt
            // 
            linkLogintxt.AutoSize = true;
            linkLogintxt.Font = new Font("Bahnschrift", 9F, FontStyle.Italic, GraphicsUnit.Point);
            linkLogintxt.ForeColor = Color.White;
            linkLogintxt.Location = new Point(692, 531);
            linkLogintxt.Margin = new Padding(4, 0, 4, 0);
            linkLogintxt.Name = "linkLogintxt";
            linkLogintxt.Size = new Size(180, 18);
            linkLogintxt.TabIndex = 5;
            linkLogintxt.Text = "Already have account yet?";
            linkLogintxt.Click += linkRegistxt_Click;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Font = new Font("Bahnschrift", 9F, FontStyle.Underline, GraphicsUnit.Point);
            linkLogin.ForeColor = Color.White;
            linkLogin.Location = new Point(880, 531);
            linkLogin.Margin = new Padding(4, 0, 4, 0);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(45, 18);
            linkLogin.TabIndex = 6;
            linkLogin.Text = "Login";
            linkLogin.Click += linkLogin_Click_1;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Bahnschrift", 15F, FontStyle.Italic, GraphicsUnit.Point);
            password.ForeColor = Color.FromArgb(125, 157, 156);
            password.Location = new Point(543, 222);
            password.Margin = new Padding(4, 0, 4, 0);
            password.Name = "password";
            password.Size = new Size(130, 30);
            password.TabIndex = 7;
            password.Text = "Password:";
            // 
            // dobInput
            // 
            dobInput.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dobInput.Location = new Point(555, 336);
            dobInput.Margin = new Padding(4);
            dobInput.Name = "dobInput";
            dobInput.Size = new Size(374, 38);
            dobInput.TabIndex = 9;
            dobInput.TabStop = false;
            // 
            // dob
            // 
            dob.AutoSize = true;
            dob.Font = new Font("Bahnschrift", 15F, FontStyle.Italic, GraphicsUnit.Point);
            dob.ForeColor = Color.FromArgb(125, 157, 156);
            dob.Location = new Point(543, 300);
            dob.Margin = new Padding(4, 0, 4, 0);
            dob.Name = "dob";
            dob.Size = new Size(67, 30);
            dob.TabIndex = 10;
            dob.Text = "DOB:";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Bahnschrift", 15F, FontStyle.Italic, GraphicsUnit.Point);
            gender.ForeColor = Color.FromArgb(125, 157, 156);
            gender.Location = new Point(543, 379);
            gender.Margin = new Padding(4, 0, 4, 0);
            gender.Name = "gender";
            gender.Size = new Size(97, 30);
            gender.TabIndex = 11;
            gender.Text = "Gender:";
            // 
            // maleInput
            // 
            maleInput.AutoSize = true;
            maleInput.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maleInput.ForeColor = Color.White;
            maleInput.Location = new Point(607, 414);
            maleInput.Margin = new Padding(4);
            maleInput.Name = "maleInput";
            maleInput.Size = new Size(63, 28);
            maleInput.TabIndex = 12;
            maleInput.TabStop = true;
            maleInput.Text = "Male";
            maleInput.UseVisualStyleBackColor = true;
            // 
            // femaleInput
            // 
            femaleInput.AutoSize = true;
            femaleInput.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            femaleInput.ForeColor = Color.White;
            femaleInput.Location = new Point(761, 414);
            femaleInput.Margin = new Padding(4);
            femaleInput.Name = "femaleInput";
            femaleInput.Size = new Size(80, 28);
            femaleInput.TabIndex = 13;
            femaleInput.TabStop = true;
            femaleInput.Text = "Female";
            femaleInput.UseVisualStyleBackColor = true;
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwordInput.Location = new Point(555, 256);
            passwordInput.Margin = new Padding(4);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(374, 38);
            passwordInput.TabIndex = 14;
            passwordInput.TabStop = false;
            // 
            // emailInput
            // 
            emailInput.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            emailInput.Location = new Point(555, 476);
            emailInput.Margin = new Padding(4);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(374, 38);
            emailInput.TabIndex = 16;
            emailInput.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Bahnschrift", 15F, FontStyle.Italic, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.FromArgb(125, 157, 156);
            lblEmail.Location = new Point(543, 442);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(75, 30);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(1000, 625);
            Controls.Add(emailInput);
            Controls.Add(lblEmail);
            Controls.Add(passwordInput);
            Controls.Add(femaleInput);
            Controls.Add(maleInput);
            Controls.Add(gender);
            Controls.Add(dob);
            Controls.Add(dobInput);
            Controls.Add(password);
            Controls.Add(leftSide);
            Controls.Add(registerTxt);
            Controls.Add(name);
            Controls.Add(usernameInput);
            Controls.Add(numberPhone);
            Controls.Add(numberPhoneInput);
            Controls.Add(registerBtn);
            Controls.Add(linkLogintxt);
            Controls.Add(linkLogin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            leftSide.ResumeLayout(false);
            leftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel leftSide;
        private PictureBox logo;
        private Label registerTxt;
        private Label name;
        private TextBox usernameInput;
        private Label numberPhone;
        private TextBox numberPhoneInput;
        private Button registerBtn;
        private Label linkLogintxt;
        private Label linkLogin;
        #endregion

        private Label password;
        private DateTimePicker dobInput;
        private Label dob;
        private Label gender;
        private RadioButton maleInput;
        private RadioButton femaleInput;
        private TextBox passwordInput;
        private TextBox emailInput;
        private Label lblEmail;
    }
}
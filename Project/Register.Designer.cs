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
            male = new RadioButton();
            female = new RadioButton();
            passwdInput = new TextBox();
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
            // registerTxt
            // 
            registerTxt.AutoSize = true;
            registerTxt.Font = new Font("Bahnschrift", 25F, FontStyle.Bold, GraphicsUnit.Point);
            registerTxt.ForeColor = Color.White;
            registerTxt.Location = new Point(527, 39);
            registerTxt.Name = "registerTxt";
            registerTxt.Size = new Size(171, 41);
            registerTxt.TabIndex = 1;
            registerTxt.Text = "REGISTER";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Bahnschrift", 15F, FontStyle.Italic, GraphicsUnit.Point);
            name.ForeColor = Color.FromArgb(125, 157, 156);
            name.Location = new Point(440, 100);
            name.Name = "name";
            name.Size = new Size(68, 24);
            name.TabIndex = 2;
            name.Text = "Name:";
            // 
            // usernameInput
            // 
            usernameInput.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usernameInput.Location = new Point(450, 130);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(300, 32);
            usernameInput.TabIndex = 3;
            usernameInput.TabStop = false;
            // 
            // numberPhone
            // 
            numberPhone.AutoSize = true;
            numberPhone.Font = new Font("Bahnschrift", 15F, FontStyle.Italic, GraphicsUnit.Point);
            numberPhone.ForeColor = Color.FromArgb(125, 157, 156);
            numberPhone.Location = new Point(440, 166);
            numberPhone.Name = "numberPhone";
            numberPhone.Size = new Size(148, 24);
            numberPhone.TabIndex = 2;
            numberPhone.Text = "Number phone:";
            // 
            // numberPhoneInput
            // 
            numberPhoneInput.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numberPhoneInput.Location = new Point(450, 196);
            numberPhoneInput.Name = "numberPhoneInput";
            numberPhoneInput.Size = new Size(300, 32);
            numberPhoneInput.TabIndex = 3;
            numberPhoneInput.TabStop = false;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(48, 227, 202);
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            registerBtn.Location = new Point(545, 445);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(100, 40);
            registerBtn.TabIndex = 4;
            registerBtn.TabStop = false;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            // 
            // linkLogintxt
            // 
            linkLogintxt.AutoSize = true;
            linkLogintxt.Font = new Font("Bahnschrift", 9F, FontStyle.Italic, GraphicsUnit.Point);
            linkLogintxt.ForeColor = Color.White;
            linkLogintxt.Location = new Point(564, 413);
            linkLogintxt.Name = "linkLogintxt";
            linkLogintxt.Size = new Size(145, 14);
            linkLogintxt.TabIndex = 5;
            linkLogintxt.Text = "Already have account yet?";
            linkLogintxt.Click += linkRegistxt_Click;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Font = new Font("Bahnschrift", 9F, FontStyle.Underline, GraphicsUnit.Point);
            linkLogin.ForeColor = Color.White;
            linkLogin.Location = new Point(708, 413);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(37, 14);
            linkLogin.TabIndex = 6;
            linkLogin.Text = "Login";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Bahnschrift", 15F, FontStyle.Italic, GraphicsUnit.Point);
            password.ForeColor = Color.FromArgb(125, 157, 156);
            password.Location = new Point(440, 230);
            password.Name = "password";
            password.Size = new Size(104, 24);
            password.TabIndex = 7;
            password.Text = "Password:";
            // 
            // dobInput
            // 
            dobInput.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dobInput.Location = new Point(450, 322);
            dobInput.Name = "dobInput";
            dobInput.Size = new Size(300, 32);
            dobInput.TabStop = false;
            dobInput.TabIndex = 9;
            // 
            // dob
            // 
            dob.AutoSize = true;
            dob.Font = new Font("Bahnschrift", 15F, FontStyle.Italic, GraphicsUnit.Point);
            dob.ForeColor = Color.FromArgb(125, 157, 156);
            dob.Location = new Point(440, 293);
            dob.Name = "dob";
            dob.Size = new Size(54, 24);
            dob.TabIndex = 10;
            dob.Text = "DOB:";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Bahnschrift", 15F, FontStyle.Italic, GraphicsUnit.Point);
            gender.ForeColor = Color.FromArgb(125, 157, 156);
            gender.Location = new Point(440, 356);
            gender.Name = "gender";
            gender.Size = new Size(80, 24);
            gender.TabIndex = 11;
            gender.Text = "Gender:";
            // 
            // male
            // 
            male.AutoSize = true;
            male.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            male.ForeColor = Color.White;
            male.Location = new Point(491, 384);
            male.Name = "male";
            male.Size = new Size(53, 23);
            male.TabIndex = 12;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            female.ForeColor = Color.White;
            female.Location = new Point(614, 384);
            female.Name = "female";
            female.Size = new Size(66, 23);
            female.TabIndex = 13;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // passwdInput
            // 
            passwdInput.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            passwdInput.Location = new Point(450, 258);
            passwdInput.Name = "passwdInput";
            passwdInput.Size = new Size(300, 32);
            passwdInput.TabIndex = 14;
            passwdInput.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(800, 500);
            Controls.Add(passwdInput);
            Controls.Add(female);
            Controls.Add(male);
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
        private RadioButton male;
        private RadioButton female;
        private TextBox passwdInput;
    }
}
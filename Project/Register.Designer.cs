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
        /// 
        private void InitializeComponent()
        {
            p1 = new Panel();
            welcome = new Label();
            username_pn = new Panel();
            user = new Label();
            userInput = new TextBox();
            password_pn = new Panel();
            pass = new Label();
            passInput = new TextBox();
            menu = new Panel();
            exit = new Button();
            p2 = new Panel();
            addr_pn = new Panel();
            address = new Label();
            addrInput = new TextBox();
            dob_pn = new Panel();
            dob = new Label();
            dobInput = new TextBox();
            name_pn = new Panel();
            name = new Label();
            nameInput = new TextBox();
            login = new Label();
            register_btn = new RButton();
            forget = new Button();
            p1.SuspendLayout();
            username_pn.SuspendLayout();
            password_pn.SuspendLayout();
            menu.SuspendLayout();
            p2.SuspendLayout();
            addr_pn.SuspendLayout();
            dob_pn.SuspendLayout();
            name_pn.SuspendLayout();
            SuspendLayout();
            // 
            // p1
            // 
            p1.BackColor = Color.FromArgb(242, 94, 91);
            p1.Controls.Add(welcome);
            p1.Location = new Point(0, 41);
            p1.Name = "p1";
            p1.Size = new Size(469, 621);
            p1.TabIndex = 0;
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
            welcome.ForeColor = Color.FromArgb(255, 253, 255);
            welcome.Location = new Point(14, 250);
            welcome.Name = "welcome";
            welcome.Size = new Size(452, 45);
            welcome.TabIndex = 0;
            welcome.Text = "Welcome to AppBanking";
            // 
            // username_pn
            // 
            username_pn.BackColor = Color.FromArgb(45, 48, 69);
            username_pn.Controls.Add(user);
            username_pn.Controls.Add(userInput);
            username_pn.Location = new Point(0, 93);
            username_pn.Name = "username_pn";
            username_pn.Size = new Size(469, 60);
            username_pn.TabIndex = 1;
            username_pn.Paint += username_pn_Paint;
            // 
            // user
            // 
            user.Image = Properties.Resources.user;
            user.ImageAlign = ContentAlignment.MiddleLeft;
            user.Location = new Point(50, 15);
            user.Name = "user";
            user.Size = new Size(30, 30);
            user.TabIndex = 0;
            // 
            // userInput
            // 
            userInput.BackColor = Color.FromArgb(43, 48, 67);
            userInput.BorderStyle = BorderStyle.None;
            userInput.ForeColor = Color.White;
            userInput.Location = new Point(100, 15);
            userInput.Name = "userInput";
            userInput.Size = new Size(300, 24);
            userInput.TabIndex = 1;
            // 
            // password_pn
            // 
            password_pn.BackColor = Color.FromArgb(45, 48, 69);
            password_pn.Controls.Add(pass);
            password_pn.Controls.Add(passInput);
            password_pn.Location = new Point(3, 159);
            password_pn.Name = "password_pn";
            password_pn.Size = new Size(469, 60);
            password_pn.TabIndex = 2;
            password_pn.Paint += Paint;
            // 
            // pass
            // 
            pass.ForeColor = Color.FromArgb(243, 95, 91);
            pass.Image = Properties.Resources.password;
            pass.Location = new Point(50, 15);
            pass.Name = "pass";
            pass.Size = new Size(30, 30);
            pass.TabIndex = 0;
            // 
            // passInput
            // 
            passInput.BackColor = Color.FromArgb(43, 48, 67);
            passInput.BorderStyle = BorderStyle.None;
            passInput.ForeColor = Color.White;
            passInput.Location = new Point(100, 15);
            passInput.Name = "passInput";
            passInput.Size = new Size(300, 24);
            passInput.TabIndex = 1;
            passInput.UseSystemPasswordChar = true;
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(39, 42, 46);
            menu.Controls.Add(exit);
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(939, 41);
            menu.TabIndex = 1;
            // 
            // exit
            // 
            exit.BackColor = Color.FromArgb(39, 42, 46);
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Image = Properties.Resources.close;
            exit.Location = new Point(889, 0);
            exit.Name = "exit";
            exit.Size = new Size(50, 41);
            exit.TabIndex = 0;
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            exit.MouseEnter += exit_MouseEnter;
            exit.MouseLeave += exit_MouseLeave;
            // 
            // p2
            // 
            p2.BackColor = Color.FromArgb(43, 44, 60);
            p2.Controls.Add(addr_pn);
            p2.Controls.Add(dob_pn);
            p2.Controls.Add(name_pn);
            p2.Controls.Add(login);
            p2.Controls.Add(username_pn);
            p2.Controls.Add(password_pn);
            p2.Controls.Add(register_btn);
            p2.Controls.Add(forget);
            p2.Location = new Point(469, 41);
            p2.Name = "p2";
            p2.Size = new Size(470, 621);
            p2.TabIndex = 2;
            // 
            // addr_pn
            // 
            addr_pn.BackColor = Color.FromArgb(45, 48, 69);
            addr_pn.Controls.Add(address);
            addr_pn.Controls.Add(addrInput);
            addr_pn.Location = new Point(3, 357);
            addr_pn.Name = "addr_pn";
            addr_pn.Size = new Size(469, 60);
            addr_pn.TabIndex = 4;
            addr_pn.Paint += Paint;
            // 
            // address
            // 
            address.ForeColor = Color.FromArgb(243, 95, 91);
            address.Image = Properties.Resources.address;
            address.Location = new Point(50, 15);
            address.Name = "address";
            address.Size = new Size(30, 30);
            address.TabIndex = 0;
            // 
            // addrInput
            // 
            addrInput.BackColor = Color.FromArgb(43, 48, 67);
            addrInput.BorderStyle = BorderStyle.None;
            addrInput.ForeColor = Color.White;
            addrInput.Location = new Point(100, 15);
            addrInput.Name = "addrInput";
            addrInput.Size = new Size(300, 24);
            addrInput.TabIndex = 1;
            // 
            // dob_pn
            // 
            dob_pn.BackColor = Color.FromArgb(45, 48, 69);
            dob_pn.Controls.Add(dob);
            dob_pn.Controls.Add(dobInput);
            dob_pn.Location = new Point(3, 291);
            dob_pn.Name = "dob_pn";
            dob_pn.Size = new Size(469, 60);
            dob_pn.TabIndex = 3;
            dob_pn.Paint += Paint;
            // 
            // dob
            // 
            dob.ForeColor = Color.FromArgb(243, 95, 91);
            dob.Image = Properties.Resources.date;
            dob.Location = new Point(50, 15);
            dob.Name = "dob";
            dob.Size = new Size(30, 30);
            dob.TabIndex = 0;
            // 
            // dobInput
            // 
            dobInput.BackColor = Color.FromArgb(43, 48, 67);
            dobInput.BorderStyle = BorderStyle.None;
            dobInput.ForeColor = Color.White;
            dobInput.Location = new Point(100, 15);
            dobInput.Name = "dobInput";
            dobInput.Size = new Size(300, 24);
            dobInput.TabIndex = 1;
            // 
            // name_pn
            // 
            name_pn.BackColor = Color.FromArgb(45, 48, 69);
            name_pn.Controls.Add(name);
            name_pn.Controls.Add(nameInput);
            name_pn.Location = new Point(3, 225);
            name_pn.Name = "name_pn";
            name_pn.Size = new Size(469, 60);
            name_pn.TabIndex = 3;
            name_pn.Paint += Paint;
            // 
            // name
            // 
            name.ForeColor = Color.FromArgb(243, 95, 91);
            name.Image = Properties.Resources.name;
            name.Location = new Point(50, 15);
            name.Name = "name";
            name.Size = new Size(30, 30);
            name.TabIndex = 0;
            // 
            // nameInput
            // 
            nameInput.BackColor = Color.FromArgb(43, 48, 67);
            nameInput.BorderStyle = BorderStyle.None;
            nameInput.ForeColor = Color.White;
            nameInput.Location = new Point(100, 15);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(300, 24);
            nameInput.TabIndex = 1;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            login.ForeColor = Color.FromArgb(138, 138, 154);
            login.Location = new Point(27, 34);
            login.Name = "login";
            login.Size = new Size(410, 46);
            login.TabIndex = 0;
            login.Text = "Register your account";
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(42, 45, 60);
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.ForeColor = Color.FromArgb(243, 95, 91);
            register_btn.Location = new Point(-35, 452);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(200, 60);
            register_btn.TabIndex = 3;
            register_btn.Text = "REGISTER";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += login_btn_Click;
            // 
            // forget
            // 
            forget.AutoSize = true;
            forget.FlatAppearance.BorderSize = 0;
            forget.FlatStyle = FlatStyle.Flat;
            forget.ForeColor = Color.FromArgb(91, 93, 109);
            forget.Location = new Point(195, 467);
            forget.Name = "forget";
            forget.Size = new Size(223, 35);
            forget.TabIndex = 4;
            forget.Text = "Already have an account?";
            forget.Click += forget_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 662);
            Controls.Add(p1);
            Controls.Add(menu);
            Controls.Add(p2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            p1.ResumeLayout(false);
            p1.PerformLayout();
            username_pn.ResumeLayout(false);
            username_pn.PerformLayout();
            password_pn.ResumeLayout(false);
            password_pn.PerformLayout();
            menu.ResumeLayout(false);
            p2.ResumeLayout(false);
            p2.PerformLayout();
            addr_pn.ResumeLayout(false);
            addr_pn.PerformLayout();
            dob_pn.ResumeLayout(false);
            dob_pn.PerformLayout();
            name_pn.ResumeLayout(false);
            name_pn.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Panel username_pn;
        private System.Windows.Forms.Panel password_pn;
        private Label user;
        private Label pass;
        private TextBox passInput;

        private RButton register_btn;
        private TextBox userInput;

        #endregion

        private Button forget;
        private Panel addr_pn;
        private Label address;
        private TextBox addrInput;
        private Panel dob_pn;
        private Label dob;
        private TextBox dobInput;
        private Panel name_pn;
        private Label name;
        private TextBox nameInput;
    }
}
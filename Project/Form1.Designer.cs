using System.Drawing;

namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p1 = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.Label();
            this.username_pn = new System.Windows.Forms.Panel();
            this.user = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.password_pn = new System.Windows.Forms.Panel();
            this.pass = new System.Windows.Forms.Label();
            this.passInput = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Label();
            this.login_btn = new Project.RButton();
            this.forget = new System.Windows.Forms.Label();
            this.p1.SuspendLayout();
            this.username_pn.SuspendLayout();
            this.password_pn.SuspendLayout();
            this.menu.SuspendLayout();
            this.p2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.p1.Controls.Add(this.welcome);
            this.p1.Location = new System.Drawing.Point(0, 41);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(469, 621);
            this.p1.TabIndex = 0;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.welcome.Location = new System.Drawing.Point(14, 250);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(452, 45);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome to AppBanking";
            // 
            // username_pn
            // 
            this.username_pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.username_pn.Controls.Add(this.user);
            this.username_pn.Controls.Add(this.userInput);
            this.username_pn.Location = new System.Drawing.Point(0, 240);
            this.username_pn.Name = "username_pn";
            this.username_pn.Size = new System.Drawing.Size(469, 60);
            this.username_pn.TabIndex = 1;
            this.username_pn.Paint += new System.Windows.Forms.PaintEventHandler(this.username_pn_Paint);
            // 
            // user
            // 
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user.Location = new System.Drawing.Point(50, 15);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(30, 30);
            this.user.TabIndex = 0;
            // 
            // userInput
            // 
            this.userInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.userInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userInput.ForeColor = System.Drawing.Color.White;
            this.userInput.Location = new System.Drawing.Point(100, 15);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(300, 24);
            this.userInput.TabIndex = 1;
            // 
            // password_pn
            // 
            this.password_pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.password_pn.Controls.Add(this.pass);
            this.password_pn.Controls.Add(this.passInput);
            this.password_pn.Location = new System.Drawing.Point(0, 300);
            this.password_pn.Name = "password_pn";
            this.password_pn.Size = new System.Drawing.Size(469, 60);
            this.password_pn.TabIndex = 2;
            this.password_pn.Paint += new System.Windows.Forms.PaintEventHandler(this.password_pn_Paint);
            // 
            // pass
            // 
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(95)))), ((int)(((byte)(91)))));
            this.pass.Image = ((System.Drawing.Image)(resources.GetObject("pass.Image")));
            this.pass.Location = new System.Drawing.Point(50, 15);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(30, 30);
            this.pass.TabIndex = 0;
            // 
            // passInput
            // 
            this.passInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.passInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passInput.ForeColor = System.Drawing.Color.White;
            this.passInput.Location = new System.Drawing.Point(100, 15);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(300, 24);
            this.passInput.TabIndex = 1;
            this.passInput.UseSystemPasswordChar = true;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.menu.Controls.Add(this.exit);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(939, 41);
            this.menu.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(889, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(50, 41);
            this.exit.TabIndex = 0;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.p2.Controls.Add(this.login);
            this.p2.Controls.Add(this.username_pn);
            this.p2.Controls.Add(this.password_pn);
            this.p2.Controls.Add(this.login_btn);
            this.p2.Controls.Add(this.forget);
            this.p2.Location = new System.Drawing.Point(469, 41);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(470, 621);
            this.p2.TabIndex = 2;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(154)))));
            this.login.Location = new System.Drawing.Point(33, 160);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(405, 46);
            this.login.TabIndex = 0;
            this.login.Text = "Login to your account";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(95)))), ((int)(((byte)(91)))));
            this.login_btn.Location = new System.Drawing.Point(-30, 400);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(200, 60);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // forget
            // 
            this.forget.AutoSize = true;
            this.forget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(93)))), ((int)(((byte)(109)))));
            this.forget.Location = new System.Drawing.Point(200, 415);
            this.forget.Name = "forget";
            this.forget.Size = new System.Drawing.Size(154, 25);
            this.forget.TabIndex = 4;
            this.forget.Text = "Forgot Password?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 662);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.p2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.username_pn.ResumeLayout(false);
            this.username_pn.PerformLayout();
            this.password_pn.ResumeLayout(false);
            this.password_pn.PerformLayout();
            this.menu.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private Label forget;
        private TextBox passInput;

        private RButton login_btn;
        private TextBox userInput;
    }
}
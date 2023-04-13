namespace Project
{
    partial class TransactionPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblPhone = new Label();
            lblMoney = new Label();
            lblName = new Label();
            btnEnter = new Button();
            txtPhone = new TextBox();
            txtMoney = new TextBox();
            btnSearch = new Button();
            nameOutput = new Label();
            btnOtp = new Button();
            txtOtp = new TextBox();
            lblOtp = new Label();
            lblOr = new Label();
            btnQRCode = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblWarning = new Label();
            SuspendLayout();
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(26, 27);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(96, 33);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone:";
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoney.ForeColor = Color.White;
            lblMoney.Location = new Point(26, 131);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(96, 33);
            lblMoney.TabIndex = 1;
            lblMoney.Text = "Money:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(26, 82);
            lblName.Name = "lblName";
            lblName.Size = new Size(90, 33);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnter.Location = new Point(315, 387);
            btnEnter.Margin = new Padding(3, 2, 3, 2);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(226, 41);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(148, 32);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(268, 28);
            txtPhone.TabIndex = 4;
            // 
            // txtMoney
            // 
            txtMoney.Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtMoney.Location = new Point(148, 136);
            txtMoney.Margin = new Padding(3, 2, 3, 2);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(268, 28);
            txtMoney.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(443, 32);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 26);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // nameOutput
            // 
            nameOutput.AutoSize = true;
            nameOutput.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameOutput.ForeColor = Color.White;
            nameOutput.Location = new Point(148, 88);
            nameOutput.Name = "nameOutput";
            nameOutput.Size = new Size(46, 23);
            nameOutput.TabIndex = 8;
            nameOutput.Text = "label1";
            // 
            // btnOtp
            // 
            btnOtp.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOtp.Location = new Point(443, 192);
            btnOtp.Margin = new Padding(3, 2, 3, 2);
            btnOtp.Name = "btnOtp";
            btnOtp.Size = new Size(98, 26);
            btnOtp.TabIndex = 9;
            btnOtp.Text = "Get OTP";
            btnOtp.UseVisualStyleBackColor = true;
            btnOtp.Click += btnOtp_Click;
            // 
            // txtOtp
            // 
            txtOtp.Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtOtp.Location = new Point(148, 192);
            txtOtp.Margin = new Padding(3, 2, 3, 2);
            txtOtp.Name = "txtOtp";
            txtOtp.Size = new Size(268, 28);
            txtOtp.TabIndex = 11;
            // 
            // lblOtp
            // 
            lblOtp.AutoSize = true;
            lblOtp.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblOtp.ForeColor = Color.White;
            lblOtp.Location = new Point(26, 187);
            lblOtp.Name = "lblOtp";
            lblOtp.Size = new Size(75, 33);
            lblOtp.TabIndex = 10;
            lblOtp.Text = "OTP: ";
            // 
            // lblOr
            // 
            lblOr.AutoSize = true;
            lblOr.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblOr.ForeColor = Color.White;
            lblOr.Location = new Point(556, 27);
            lblOr.Name = "lblOr";
            lblOr.Size = new Size(44, 33);
            lblOr.TabIndex = 12;
            lblOr.Text = "Or";
            // 
            // btnQRCode
            // 
            btnQRCode.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnQRCode.Location = new Point(620, 32);
            btnQRCode.Margin = new Padding(3, 2, 3, 2);
            btnQRCode.Name = "btnQRCode";
            btnQRCode.Size = new Size(98, 26);
            btnQRCode.TabIndex = 13;
            btnQRCode.Text = "QR Code";
            btnQRCode.UseVisualStyleBackColor = true;
            btnQRCode.Click += btnQRCode_Click;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(231, 354);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(382, 33);
            lblWarning.TabIndex = 14;
            lblWarning.Text = "This account has been banned!";
            // 
            // TransactionPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            Controls.Add(lblWarning);
            Controls.Add(btnQRCode);
            Controls.Add(lblOr);
            Controls.Add(txtOtp);
            Controls.Add(lblOtp);
            Controls.Add(btnOtp);
            Controls.Add(nameOutput);
            Controls.Add(btnSearch);
            Controls.Add(txtMoney);
            Controls.Add(txtPhone);
            Controls.Add(btnEnter);
            Controls.Add(lblName);
            Controls.Add(lblMoney);
            Controls.Add(lblPhone);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TransactionPanel";
            Size = new Size(861, 482);
            Load += TransactionPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPhone;
        private Label lblMoney;
        private Label lblName;
        private Button btnEnter;
        private TextBox txtPhone;
        private TextBox txtMoney;
        private Button btnSearch;
        private Label nameOutput;
        private Button btnOtp;
        private TextBox txtOtp;
        private Label lblOtp;
        private Label lblOr;
        private Button btnQRCode;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Label lblWarning;
    }
}

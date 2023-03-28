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
            SuspendLayout();
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(30, 36);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(121, 41);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone:";
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoney.ForeColor = Color.White;
            lblMoney.Location = new Point(30, 175);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(121, 41);
            lblMoney.TabIndex = 1;
            lblMoney.Text = "Money:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(30, 109);
            lblName.Name = "lblName";
            lblName.Size = new Size(114, 41);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnter.Location = new Point(360, 516);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(258, 55);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(169, 43);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(306, 34);
            txtPhone.TabIndex = 4;
            // 
            // txtMoney
            // 
            txtMoney.Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtMoney.Location = new Point(169, 182);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(306, 34);
            txtMoney.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(506, 43);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // nameOutput
            // 
            nameOutput.AutoSize = true;
            nameOutput.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            nameOutput.ForeColor = Color.White;
            nameOutput.Location = new Point(169, 118);
            nameOutput.Name = "nameOutput";
            nameOutput.Size = new Size(76, 31);
            nameOutput.TabIndex = 8;
            nameOutput.Text = "label1";
            // 
            // btnOtp
            // 
            btnOtp.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOtp.Location = new Point(506, 256);
            btnOtp.Name = "btnOtp";
            btnOtp.Size = new Size(112, 34);
            btnOtp.TabIndex = 9;
            btnOtp.Text = "Get OTP";
            btnOtp.UseVisualStyleBackColor = true;
            btnOtp.Click += btnOtp_Click;
            // 
            // txtOtp
            // 
            txtOtp.Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtOtp.Location = new Point(169, 256);
            txtOtp.Name = "txtOtp";
            txtOtp.Size = new Size(306, 34);
            txtOtp.TabIndex = 11;
            // 
            // lblOtp
            // 
            lblOtp.AutoSize = true;
            lblOtp.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblOtp.ForeColor = Color.White;
            lblOtp.Location = new Point(30, 249);
            lblOtp.Name = "lblOtp";
            lblOtp.Size = new Size(93, 41);
            lblOtp.TabIndex = 10;
            lblOtp.Text = "OTP: ";
            // 
            // TransactionPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
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
            Name = "TransactionPanel";
            Size = new Size(984, 642);
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
    }
}

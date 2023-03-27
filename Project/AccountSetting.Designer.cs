using System.Diagnostics;

namespace Project
{
    partial class AccountSetting
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
            txtName = new TextBox();
            lblMoney = new Label();
            lblPhone = new Label();
            lblName = new Label();
            lblPass = new Label();
            txtPass = new TextBox();
            btnUpdate = new Button();
            moneyOutput = new Label();
            phoneOutput = new Label();
            lblDOB = new Label();
            txtDOB = new DateTimePicker();
            lblGender = new Label();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(224, 202);
            txtName.Name = "txtName";
            txtName.Size = new Size(306, 34);
            txtName.TabIndex = 9;
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoney.ForeColor = Color.White;
            lblMoney.Location = new Point(97, 123);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(121, 41);
            lblMoney.TabIndex = 7;
            lblMoney.Text = "Money:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(97, 56);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(121, 41);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(104, 195);
            lblName.Name = "lblName";
            lblName.Size = new Size(114, 41);
            lblName.TabIndex = 10;
            lblName.Text = "Name:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.ForeColor = Color.White;
            lblPass.Location = new Point(47, 273);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(178, 41);
            lblPass.TabIndex = 12;
            lblPass.Text = "Password:";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(224, 281);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(306, 34);
            txtPass.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(369, 548);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(258, 55);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // moneyOutput
            // 
            moneyOutput.AutoSize = true;
            moneyOutput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            moneyOutput.ForeColor = Color.White;
            moneyOutput.Location = new Point(224, 123);
            moneyOutput.Name = "moneyOutput";
            moneyOutput.Size = new Size(0, 41);
            moneyOutput.TabIndex = 14;
            // 
            // phoneOutput
            // 
            phoneOutput.AutoSize = true;
            phoneOutput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            phoneOutput.ForeColor = Color.White;
            phoneOutput.Location = new Point(224, 56);
            phoneOutput.Name = "phoneOutput";
            phoneOutput.Size = new Size(0, 41);
            phoneOutput.TabIndex = 15;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblDOB.ForeColor = Color.White;
            lblDOB.Location = new Point(133, 350);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(91, 41);
            lblDOB.TabIndex = 16;
            lblDOB.Text = "DOB:";
            // 
            // txtDOB
            // 
            txtDOB.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtDOB.Location = new Point(224, 350);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(341, 38);
            txtDOB.TabIndex = 17;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(91, 412);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(134, 41);
            lblGender.TabIndex = 18;
            lblGender.Text = "Gender:";
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdMale.ForeColor = Color.White;
            rdMale.Location = new Point(258, 423);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(63, 28);
            rdMale.TabIndex = 19;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdFemale.ForeColor = Color.White;
            rdFemale.Location = new Point(415, 423);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(80, 28);
            rdFemale.TabIndex = 20;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // AccountSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(lblGender);
            Controls.Add(txtDOB);
            Controls.Add(lblDOB);
            Controls.Add(phoneOutput);
            Controls.Add(moneyOutput);
            Controls.Add(btnUpdate);
            Controls.Add(lblPass);
            Controls.Add(txtPass);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblMoney);
            Controls.Add(lblPhone);
            Name = "AccountSetting";
            Size = new Size(984, 642);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblMoney;
        private Label lblPhone;
        private Label lblName;
        private Label lblPass;
        private TextBox txtPass;
        private Button btnUpdate;
        private Label moneyOutput;
        private Label phoneOutput;
        private Label lblDOB;
        private DateTimePicker txtDOB;
        private Label lblGender;
        private RadioButton rdMale;
        private RadioButton rdFemale;
    }
}

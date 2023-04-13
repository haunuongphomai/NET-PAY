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
            txtName.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(196, 152);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(299, 32);
            txtName.TabIndex = 9;
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoney.ForeColor = Color.White;
            lblMoney.Location = new Point(88, 92);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(96, 33);
            lblMoney.TabIndex = 7;
            lblMoney.Text = "Money:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(90, 42);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(96, 33);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(94, 147);
            lblName.Name = "lblName";
            lblName.Size = new Size(90, 33);
            lblName.TabIndex = 10;
            lblName.Text = "Name:";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(317, 399);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(226, 41);
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
            moneyOutput.Location = new Point(196, 92);
            moneyOutput.Name = "moneyOutput";
            moneyOutput.Size = new Size(0, 32);
            moneyOutput.TabIndex = 14;
            // 
            // phoneOutput
            // 
            phoneOutput.AutoSize = true;
            phoneOutput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            phoneOutput.ForeColor = Color.White;
            phoneOutput.Location = new Point(196, 42);
            phoneOutput.Name = "phoneOutput";
            phoneOutput.Size = new Size(0, 32);
            phoneOutput.TabIndex = 15;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblDOB.ForeColor = Color.White;
            lblDOB.Location = new Point(109, 200);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(72, 33);
            lblDOB.TabIndex = 16;
            lblDOB.Text = "DOB:";
            // 
            // txtDOB
            // 
            txtDOB.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtDOB.Location = new Point(196, 201);
            txtDOB.Margin = new Padding(3, 2, 3, 2);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(299, 32);
            txtDOB.TabIndex = 17;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(80, 309);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(106, 33);
            lblGender.TabIndex = 18;
            lblGender.Text = "Gender:";
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdMale.ForeColor = Color.White;
            rdMale.Location = new Point(226, 317);
            rdMale.Margin = new Padding(3, 2, 3, 2);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(58, 27);
            rdMale.TabIndex = 19;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdFemale.ForeColor = Color.White;
            rdFemale.Location = new Point(363, 317);
            rdFemale.Margin = new Padding(3, 2, 3, 2);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(73, 27);
            rdFemale.TabIndex = 20;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // AccountSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblMoney);
            Controls.Add(lblPhone);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AccountSetting";
            Size = new Size(861, 482);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblMoney;
        private Label lblPhone;
        private Label lblName;
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

namespace Project
{
    partial class HomePanelAdmin
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
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            lblGender = new Label();
            txtDOB = new DateTimePicker();
            lblDOB = new Label();
            phoneOutput = new Label();
            moneyOutput = new Label();
            btnUpdate = new Button();
            lblPass = new Label();
            txtPass = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblMoney = new Label();
            lblPhone = new Label();
            SuspendLayout();
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdFemale.ForeColor = Color.White;
            rdFemale.Location = new Point(363, 319);
            rdFemale.Margin = new Padding(3, 2, 3, 2);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(66, 23);
            rdFemale.TabIndex = 34;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdMale.ForeColor = Color.White;
            rdMale.Location = new Point(226, 319);
            rdMale.Margin = new Padding(3, 2, 3, 2);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(53, 23);
            rdMale.TabIndex = 33;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(80, 310);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(106, 33);
            lblGender.TabIndex = 32;
            lblGender.Text = "Gender:";
            // 
            // txtDOB
            // 
            txtDOB.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtDOB.Location = new Point(196, 264);
            txtDOB.Margin = new Padding(3, 2, 3, 2);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(299, 32);
            txtDOB.TabIndex = 31;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblDOB.ForeColor = Color.White;
            lblDOB.Location = new Point(116, 264);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(72, 33);
            lblDOB.TabIndex = 30;
            lblDOB.Text = "DOB:";
            // 
            // phoneOutput
            // 
            phoneOutput.AutoSize = true;
            phoneOutput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            phoneOutput.ForeColor = Color.White;
            phoneOutput.Location = new Point(196, 44);
            phoneOutput.Name = "phoneOutput";
            phoneOutput.Size = new Size(0, 32);
            phoneOutput.TabIndex = 29;
            // 
            // moneyOutput
            // 
            moneyOutput.AutoSize = true;
            moneyOutput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            moneyOutput.ForeColor = Color.White;
            moneyOutput.Location = new Point(196, 94);
            moneyOutput.Name = "moneyOutput";
            moneyOutput.Size = new Size(0, 32);
            moneyOutput.TabIndex = 28;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(323, 412);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(226, 41);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.ForeColor = Color.White;
            lblPass.Location = new Point(41, 206);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(142, 33);
            lblPass.TabIndex = 26;
            lblPass.Text = "Password:";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(196, 212);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(268, 28);
            txtPass.TabIndex = 25;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(91, 148);
            lblName.Name = "lblName";
            lblName.Size = new Size(90, 33);
            lblName.TabIndex = 24;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(196, 153);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(268, 28);
            txtName.TabIndex = 23;
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblMoney.ForeColor = Color.White;
            lblMoney.Location = new Point(85, 94);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(96, 33);
            lblMoney.TabIndex = 22;
            lblMoney.Text = "Money:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(85, 44);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(96, 33);
            lblPhone.TabIndex = 21;
            lblPhone.Text = "Phone:";
            // 
            // HomePanelAdmin
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
            Controls.Add(lblPass);
            Controls.Add(txtPass);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblMoney);
            Controls.Add(lblPhone);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomePanelAdmin";
            Size = new Size(861, 482);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdFemale;
        private RadioButton rdMale;
        private Label lblGender;
        private DateTimePicker txtDOB;
        private Label lblDOB;
        private Label phoneOutput;
        private Label moneyOutput;
        private Button btnUpdate;
        private Label lblPass;
        private TextBox txtPass;
        private Label lblName;
        private TextBox txtName;
        private Label lblMoney;
        private Label lblPhone;
    }
}

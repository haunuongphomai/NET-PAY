namespace Project
{
    partial class Invoices
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
            menuStrip1 = new MenuStrip();
            pDFToolStripMenuItem = new ToolStripMenuItem();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            lblIntro = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblName = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SNameOutput = new Label();
            SPhoneOutput = new Label();
            SMailOutput = new Label();
            moneyOutput = new Label();
            dateOutput = new Label();
            RPhoneOutput = new Label();
            RNameOutput = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pDFToolStripMenuItem, sendEmailToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // pDFToolStripMenuItem
            // 
            pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            pDFToolStripMenuItem.Size = new Size(49, 24);
            pDFToolStripMenuItem.Text = "PDF";
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(97, 24);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // lblIntro
            // 
            lblIntro.AutoSize = true;
            lblIntro.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblIntro.Location = new Point(307, 140);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(165, 46);
            lblIntro.TabIndex = 0;
            lblIntro.Text = "INVOICES";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lblIntro);
            panel1.Location = new Point(2, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 688);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateOutput);
            groupBox1.Controls.Add(moneyOutput);
            groupBox1.Controls.Add(SMailOutput);
            groupBox1.Controls.Add(SPhoneOutput);
            groupBox1.Controls.Add(SNameOutput);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new Point(52, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(683, 288);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 138);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 186);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 8;
            label3.Text = "Money:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 89);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 7;
            label2.Text = "Phone:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(21, 43);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 28);
            lblName.TabIndex = 6;
            lblName.Text = "Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RPhoneOutput);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(RNameOutput);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(52, 512);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(683, 130);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Receiver";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(21, 89);
            label6.Name = "label6";
            label6.Size = new Size(76, 28);
            label6.TabIndex = 7;
            label6.Text = "Phone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(21, 43);
            label7.Name = "label7";
            label7.Size = new Size(73, 28);
            label7.TabIndex = 6;
            label7.Text = "Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(24, 235);
            label8.Name = "label8";
            label8.Size = new Size(62, 28);
            label8.TabIndex = 10;
            label8.Text = "Date:";
            // 
            // SNameOutput
            // 
            SNameOutput.AutoSize = true;
            SNameOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SNameOutput.Location = new Point(100, 43);
            SNameOutput.Name = "SNameOutput";
            SNameOutput.Size = new Size(65, 28);
            SNameOutput.TabIndex = 11;
            SNameOutput.Text = "label5";
            // 
            // SPhoneOutput
            // 
            SPhoneOutput.AutoSize = true;
            SPhoneOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SPhoneOutput.Location = new Point(100, 89);
            SPhoneOutput.Name = "SPhoneOutput";
            SPhoneOutput.Size = new Size(65, 28);
            SPhoneOutput.TabIndex = 12;
            SPhoneOutput.Text = "label5";
            // 
            // SMailOutput
            // 
            SMailOutput.AutoSize = true;
            SMailOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SMailOutput.Location = new Point(100, 138);
            SMailOutput.Name = "SMailOutput";
            SMailOutput.Size = new Size(65, 28);
            SMailOutput.TabIndex = 13;
            SMailOutput.Text = "label5";
            // 
            // moneyOutput
            // 
            moneyOutput.AutoSize = true;
            moneyOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            moneyOutput.Location = new Point(100, 186);
            moneyOutput.Name = "moneyOutput";
            moneyOutput.Size = new Size(65, 28);
            moneyOutput.TabIndex = 14;
            moneyOutput.Text = "label5";
            // 
            // dateOutput
            // 
            dateOutput.AutoSize = true;
            dateOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateOutput.Location = new Point(100, 235);
            dateOutput.Name = "dateOutput";
            dateOutput.Size = new Size(65, 28);
            dateOutput.TabIndex = 15;
            dateOutput.Text = "label5";
            // 
            // RPhoneOutput
            // 
            RPhoneOutput.AutoSize = true;
            RPhoneOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RPhoneOutput.Location = new Point(100, 89);
            RPhoneOutput.Name = "RPhoneOutput";
            RPhoneOutput.Size = new Size(65, 28);
            RPhoneOutput.TabIndex = 17;
            RPhoneOutput.Text = "label5";
            // 
            // RNameOutput
            // 
            RNameOutput.AutoSize = true;
            RNameOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RNameOutput.Location = new Point(100, 43);
            RNameOutput.Name = "RNameOutput";
            RNameOutput.Size = new Size(65, 28);
            RNameOutput.TabIndex = 16;
            RNameOutput.Text = "label5";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(605, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 164);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Invoices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 740);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Invoices";
            Text = "Invoices";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pDFToolStripMenuItem;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private Label lblIntro;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblName;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label SNameOutput;
        private Label SPhoneOutput;
        private Label dateOutput;
        private Label moneyOutput;
        private Label SMailOutput;
        private Label RPhoneOutput;
        private Label RNameOutput;
        private PictureBox pictureBox1;
    }
}
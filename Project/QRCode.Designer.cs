﻿namespace Project
{
    partial class QRCode
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
            components = new System.ComponentModel.Container();
            imgQRCode = new PictureBox();
            cboDevice = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)imgQRCode).BeginInit();
            SuspendLayout();
            // 
            // imgQRCode
            // 
            imgQRCode.BackColor = Color.White;
            imgQRCode.Location = new Point(1, 2);
            imgQRCode.Margin = new Padding(3, 2, 3, 2);
            imgQRCode.Name = "imgQRCode";
            imgQRCode.Size = new Size(841, 505);
            imgQRCode.TabIndex = 15;
            imgQRCode.TabStop = false;
            // 
            // cboDevice
            // 
            cboDevice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cboDevice.FormattingEnabled = true;
            cboDevice.Location = new Point(25, 9);
            cboDevice.Margin = new Padding(3, 2, 3, 2);
            cboDevice.Name = "cboDevice";
            cboDevice.Size = new Size(452, 40);
            cboDevice.TabIndex = 16;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // QRCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 513);
            Controls.Add(cboDevice);
            Controls.Add(imgQRCode);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QRCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QRCode";
            FormClosing += QRCode_FormClosing;
            Load += QRCode_Load;
            ((System.ComponentModel.ISupportInitialize)imgQRCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgQRCode;
        private ComboBox cboDevice;
        private System.Windows.Forms.Timer timer1;
    }
}
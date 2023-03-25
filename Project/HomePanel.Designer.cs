using System.Diagnostics;

namespace Project
{
    partial class HomePanel
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
            creditCard = new PictureBox();
            nameCard = new Label();
            visa = new Label();
            creditcardBehind = new PictureBox();
            seriId = new Label();
            accountId = new Label();
            accountName = new Label();
            startDay = new Label();
            cvv = new Label();
            balanced = new Label();
            name = new Label();
            id = new Label();
            qrCodeimg = new PictureBox();
            qrCode = new Label();
            lblBalance = new Label();
            lblPhone = new Label();
            lblName = new Label();
            IdOutput = new Label();
            nameOutput = new Label();
            ((System.ComponentModel.ISupportInitialize)creditCard).BeginInit();
            creditCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)creditcardBehind).BeginInit();
            creditcardBehind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qrCodeimg).BeginInit();
            SuspendLayout();
            // 
            // creditCard
            // 
            creditCard.BackColor = Color.FromArgb(57, 62, 70);
            creditCard.Controls.Add(nameCard);
            creditCard.Controls.Add(visa);
            creditCard.Image = Properties.Resources.creditcard;
            creditCard.Location = new Point(29, 36);
            creditCard.Name = "creditCard";
            creditCard.Size = new Size(412, 230);
            creditCard.SizeMode = PictureBoxSizeMode.AutoSize;
            creditCard.TabIndex = 23;
            creditCard.TabStop = false;
            // 
            // nameCard
            // 
            nameCard.AutoSize = true;
            nameCard.BackColor = Color.Transparent;
            nameCard.Font = new Font("Bahnschrift", 13F, FontStyle.Bold, GraphicsUnit.Point);
            nameCard.ForeColor = Color.White;
            nameCard.Location = new Point(10, 10);
            nameCard.Name = "nameCard";
            nameCard.Size = new Size(134, 27);
            nameCard.TabIndex = 0;
            nameCard.Text = "NET PAYPAL";
            // 
            // visa
            // 
            visa.AutoSize = true;
            visa.BackColor = Color.Transparent;
            visa.Font = new Font("Bahnschrift", 15F, FontStyle.Bold, GraphicsUnit.Point);
            visa.ForeColor = Color.White;
            visa.Location = new Point(355, 200);
            visa.Name = "visa";
            visa.Size = new Size(66, 30);
            visa.TabIndex = 1;
            visa.Text = "VISA";
            // 
            // creditcardBehind
            // 
            creditcardBehind.BackColor = Color.FromArgb(57, 62, 70);
            creditcardBehind.Controls.Add(seriId);
            creditcardBehind.Controls.Add(accountId);
            creditcardBehind.Controls.Add(accountName);
            creditcardBehind.Controls.Add(startDay);
            creditcardBehind.Controls.Add(cvv);
            creditcardBehind.Image = Properties.Resources.creditcard;
            creditcardBehind.Location = new Point(544, 36);
            creditcardBehind.Name = "creditcardBehind";
            creditcardBehind.Size = new Size(412, 230);
            creditcardBehind.SizeMode = PictureBoxSizeMode.AutoSize;
            creditcardBehind.TabIndex = 24;
            creditcardBehind.TabStop = false;
            // 
            // seriId
            // 
            seriId.BackColor = Color.FromArgb(217, 217, 217);
            seriId.Location = new Point(0, 50);
            seriId.Name = "seriId";
            seriId.Size = new Size(412, 38);
            seriId.TabIndex = 0;
            // 
            // accountId
            // 
            accountId.AutoSize = true;
            accountId.BackColor = Color.Transparent;
            accountId.Font = new Font("Bahnschrift", 12F, FontStyle.Italic, GraphicsUnit.Point);
            accountId.ForeColor = Color.White;
            accountId.Location = new Point(10, 100);
            accountId.Name = "accountId";
            accountId.Size = new Size(111, 24);
            accountId.TabIndex = 1;
            accountId.Text = "Account ID:";
            // 
            // accountName
            // 
            accountName.AutoSize = true;
            accountName.BackColor = Color.Transparent;
            accountName.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            accountName.ForeColor = Color.White;
            accountName.Location = new Point(10, 130);
            accountName.Name = "accountName";
            accountName.Size = new Size(68, 24);
            accountName.TabIndex = 2;
            accountName.Text = "Name:";
            // 
            // startDay
            // 
            startDay.AutoSize = true;
            startDay.BackColor = Color.Transparent;
            startDay.Font = new Font("Bahnschrift", 8F, FontStyle.Bold, GraphicsUnit.Point);
            startDay.ForeColor = Color.White;
            startDay.Location = new Point(10, 180);
            startDay.Name = "startDay";
            startDay.Size = new Size(57, 34);
            startDay.TabIndex = 3;
            startDay.Text = "Expired\r\nEnd:";
            // 
            // cvv
            // 
            cvv.AutoSize = true;
            cvv.BackColor = Color.Transparent;
            cvv.Font = new Font("Bahnschrift", 8F, FontStyle.Italic, GraphicsUnit.Point);
            cvv.ForeColor = Color.White;
            cvv.Location = new Point(150, 190);
            cvv.Name = "cvv";
            cvv.Size = new Size(36, 17);
            cvv.TabIndex = 4;
            cvv.Text = "CVV:";
            // 
            // balanced
            // 
            balanced.AutoSize = true;
            balanced.BackColor = Color.Transparent;
            balanced.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            balanced.ForeColor = Color.White;
            balanced.Location = new Point(29, 336);
            balanced.Name = "balanced";
            balanced.Size = new Size(166, 41);
            balanced.TabIndex = 25;
            balanced.Text = "Balanced:";
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.Transparent;
            name.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            name.ForeColor = Color.White;
            name.Location = new Point(29, 416);
            name.Name = "name";
            name.Size = new Size(114, 41);
            name.TabIndex = 26;
            name.Text = "Name:";
            // 
            // id
            // 
            id.AutoSize = true;
            id.BackColor = Color.Transparent;
            id.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            id.ForeColor = Color.White;
            id.Location = new Point(29, 496);
            id.Name = "id";
            id.Size = new Size(189, 41);
            id.TabIndex = 27;
            id.Text = "Account ID:";
            // 
            // qrCodeimg
            // 
            qrCodeimg.BackColor = Color.White;
            qrCodeimg.Image = Properties.Resources.qrcode;
            qrCodeimg.Location = new Point(544, 316);
            qrCodeimg.Name = "qrCodeimg";
            qrCodeimg.Size = new Size(230, 230);
            qrCodeimg.TabIndex = 28;
            qrCodeimg.TabStop = false;
            // 
            // qrCode
            // 
            qrCode.AutoSize = true;
            qrCode.Font = new Font("Bahnschrift", 20F, FontStyle.Regular, GraphicsUnit.Point);
            qrCode.ForeColor = Color.White;
            qrCode.Location = new Point(569, 566);
            qrCode.Name = "qrCode";
            qrCode.Size = new Size(225, 41);
            qrCode.TabIndex = 29;
            qrCode.Text = "Your QR Code";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblBalance.ForeColor = Color.White;
            lblBalance.Location = new Point(218, 339);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(0, 38);
            lblBalance.TabIndex = 30;
            lblBalance.Text = acc.Instance.getBalance;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(218, 496);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 38);
            lblPhone.TabIndex = 31;
            lblPhone.Text = acc.Instance.getPhone;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(218, 416);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 38);
            lblName.TabIndex = 32;
            lblName.Text = acc.Instance.getUsername;
            // 
            // IdOutput
            // 
            IdOutput.AutoSize = true;
            IdOutput.BackColor = Color.Transparent;
            IdOutput.Font = new Font("Bahnschrift", 12F, FontStyle.Italic, GraphicsUnit.Point);
            IdOutput.ForeColor = Color.White;
            IdOutput.Location = new Point(671, 136);
            IdOutput.Name = "IdOutput";
            IdOutput.Size = new Size(0, 24);
            IdOutput.TabIndex = 33;
            IdOutput.Text = acc.Instance.getPhone;
            // 
            // nameOutput
            // 
            nameOutput.AutoSize = true;
            nameOutput.BackColor = Color.Transparent;
            nameOutput.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nameOutput.ForeColor = Color.White;
            nameOutput.Location = new Point(671, 166);
            nameOutput.Name = "nameOutput";
            nameOutput.Size = new Size(0, 24);
            nameOutput.TabIndex = 34;
            nameOutput.Text = acc.Instance.getUsername;
            // 
            // HomePanel
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(57, 62, 70);
            Controls.Add(nameOutput);
            Controls.Add(IdOutput);
            Controls.Add(lblName);
            Controls.Add(lblPhone);
            Controls.Add(lblBalance);
            Controls.Add(creditCard);
            Controls.Add(creditcardBehind);
            Controls.Add(balanced);
            Controls.Add(name);
            Controls.Add(id);
            Controls.Add(qrCodeimg);
            Controls.Add(qrCode);
            Name = "HomePanel";
            Size = new Size(984, 642);
            ((System.ComponentModel.ISupportInitialize)creditCard).EndInit();
            creditCard.ResumeLayout(false);
            creditCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)creditcardBehind).EndInit();
            creditcardBehind.ResumeLayout(false);
            creditcardBehind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)qrCodeimg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox creditCard;
        private Label nameCard;
        private Label visa;
        private PictureBox creditcardBehind;
        private Label seriId;
        private Label accountId;
        private Label accountName;
        private Label startDay;
        private Label cvv;
        private Label balanced;
        private Label name;
        private Label id;
        private PictureBox qrCodeimg;
        private Label qrCode;
        public Label lblBalance;
        private Label lblPhone;
        private Label lblName;
        private Label IdOutput;
        private Label nameOutput;
    }
}

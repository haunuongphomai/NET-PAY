namespace Project
{
    partial class History
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
            label1 = new Label();
            historyTable = new DataGridView();
            btnExport = new Button();
            btnInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)historyTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 33);
            label1.TabIndex = 0;
            label1.Text = "Transaction History";
            // 
            // historyTable
            // 
            historyTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyTable.Location = new Point(77, 115);
            historyTable.Margin = new Padding(2);
            historyTable.Name = "historyTable";
            historyTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            historyTable.RowTemplate.Height = 29;
            historyTable.Size = new Size(844, 235);
            historyTable.TabIndex = 1;
            historyTable.CellClick += historyTable_CellClick;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExport.Location = new Point(200, 421);
            btnExport.Margin = new Padding(2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(206, 44);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnInvoice
            // 
            btnInvoice.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvoice.Location = new Point(553, 421);
            btnInvoice.Margin = new Padding(2);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(206, 44);
            btnInvoice.TabIndex = 9;
            btnInvoice.Text = "Invoice";
            btnInvoice.UseVisualStyleBackColor = true;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(57, 62, 70);
            Controls.Add(btnInvoice);
            Controls.Add(btnExport);
            Controls.Add(historyTable);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "History";
            Size = new Size(984, 642);
            ((System.ComponentModel.ISupportInitialize)historyTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView historyTable;
        private Button btnExport;
        private Button btnInvoice;
    }
}

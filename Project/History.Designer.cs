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
            txtSearch = new TextBox();
            btnInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)historyTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(304, 46);
            label1.TabIndex = 0;
            label1.Text = "Transaction History";
            // 
            // historyTable
            // 
            historyTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyTable.Location = new Point(24, 130);
            historyTable.Name = "historyTable";
            historyTable.RowHeadersWidth = 51;
            historyTable.RowTemplate.Height = 29;
            historyTable.Size = new Size(940, 188);
            historyTable.TabIndex = 1;
            historyTable.CellClick += historyTable_CellClick;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExport.Location = new Point(192, 526);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(258, 55);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(614, 76);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(350, 34);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // btnInvoice
            // 
            btnInvoice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvoice.Location = new Point(483, 526);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(258, 55);
            btnInvoice.TabIndex = 9;
            btnInvoice.Text = "Invoice";
            btnInvoice.UseVisualStyleBackColor = true;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(57, 62, 70);
            Controls.Add(btnInvoice);
            Controls.Add(txtSearch);
            Controls.Add(btnExport);
            Controls.Add(historyTable);
            Controls.Add(label1);
            Name = "History";
            Size = new Size(984, 642);
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)historyTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView historyTable;
        private Button btnExport;
        private TextBox txtSearch;
        private Button btnInvoice;
    }
}

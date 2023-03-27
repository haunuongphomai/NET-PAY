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
            historyTable.Location = new Point(24, 88);
            historyTable.Name = "historyTable";
            historyTable.RowHeadersWidth = 51;
            historyTable.RowTemplate.Height = 29;
            historyTable.Size = new Size(940, 188);
            historyTable.TabIndex = 1;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnExport.Location = new Point(366, 520);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(258, 55);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(57, 62, 70);
            Controls.Add(btnExport);
            Controls.Add(historyTable);
            Controls.Add(label1);
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
    }
}

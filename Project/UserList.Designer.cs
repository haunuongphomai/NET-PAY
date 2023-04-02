namespace Project
{
    partial class UserList
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
            userTable = new DataGridView();
            btnDelete = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)userTable).BeginInit();
            SuspendLayout();
            // 
            // userTable
            // 
            userTable.AllowUserToAddRows = false;
            userTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userTable.Location = new Point(21, 134);
            userTable.Name = "userTable";
            userTable.RowHeadersWidth = 51;
            userTable.Size = new Size(941, 188);
            userTable.TabIndex = 0;
            userTable.CellValueChanged += userTable_CellValueChanged;
            userTable.DataBindingComplete += userTable_DataBindingComplete;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(356, 509);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(258, 55);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Bahnschrift", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(21, 53);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(350, 34);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += search_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(userTable);
            Name = "UserList";
            Size = new Size(984, 642);
            Load += UserList_Load;
            ((System.ComponentModel.ISupportInitialize)userTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView userTable;
        private Button btnDelete;
        private TextBox txtSearch;
    }
}

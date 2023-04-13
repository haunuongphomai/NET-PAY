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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnDelete = new Button();
            userTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)userTable).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(367, 466);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(226, 41);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // userTable
            // 
            userTable.AllowUserToAddRows = false;
            userTable.AllowUserToResizeColumns = false;
            userTable.AllowUserToResizeRows = false;
            userTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            userTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userTable.Location = new Point(59, 114);
            userTable.Margin = new Padding(3, 2, 3, 2);
            userTable.Name = "userTable";
            userTable.RowHeadersVisible = false;
            userTable.RowHeadersWidth = 21;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "f";
            dataGridViewCellStyle1.NullValue = null;
            userTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            userTable.Size = new Size(867, 300);
            userTable.TabIndex = 7;
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            Controls.Add(userTable);
            Controls.Add(btnDelete);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserList";
            Size = new Size(984, 642);
            ((System.ComponentModel.ISupportInitialize)userTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDelete;
        private DataGridView userTable;
    }
}

namespace library
{
    partial class ManageBorrowsForm
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
            dataGridViewBorrows = new DataGridView();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorrows).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBorrows
            // 
            dataGridViewBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBorrows.Location = new Point(12, 86);
            dataGridViewBorrows.Name = "dataGridViewBorrows";
            dataGridViewBorrows.RowHeadersWidth = 51;
            dataGridViewBorrows.Size = new Size(776, 188);
            dataGridViewBorrows.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(104, 319);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(553, 319);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "به روزرسانی";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(337, 319);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "ادیت";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // ManageBorrowsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(dataGridViewBorrows);
            Name = "ManageBorrowsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "صفحه ی مدیریت امانات";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorrows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewBorrows;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnEdit;
    }
}
namespace library
{
    partial class ShowAllBorrows
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
            label1 = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorrows).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBorrows
            // 
            dataGridViewBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBorrows.Location = new Point(12, 114);
            dataGridViewBorrows.Name = "dataGridViewBorrows";
            dataGridViewBorrows.RowHeadersWidth = 51;
            dataGridViewBorrows.Size = new Size(776, 188);
            dataGridViewBorrows.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 35);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 1;
            label1.Text = "نمایش تمام امانت ها ";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(359, 364);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "به روزرسانی";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ShowAllBorrows
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(label1);
            Controls.Add(dataGridViewBorrows);
            Name = "ShowAllBorrows";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نمایش همه ی امانات";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorrows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBorrows;
        private Label label1;
        private Button btnRefresh;
    }
}
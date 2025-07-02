namespace library
{
    partial class UserMainForm
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
            btnRenew = new Button();
            btnManageCredit = new Button();
            btnupdate = new Button();
            label1 = new Label();
            txtCountBooks = new Label();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            بازگشتبهصفحهورودToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorrows).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBorrows
            // 
            dataGridViewBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBorrows.Location = new Point(12, 115);
            dataGridViewBorrows.Name = "dataGridViewBorrows";
            dataGridViewBorrows.RowHeadersWidth = 51;
            dataGridViewBorrows.Size = new Size(776, 188);
            dataGridViewBorrows.TabIndex = 0;
            // 
            // btnRenew
            // 
            btnRenew.Location = new Point(587, 351);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(94, 29);
            btnRenew.TabIndex = 1;
            btnRenew.Text = "تمدید";
            btnRenew.UseVisualStyleBackColor = true;
            btnRenew.SizeChanged += btnRenew_SizeChanged;
            btnRenew.Click += btnRenew_Click;
            btnRenew.Resize += btnRenew_Resize;
            // 
            // btnManageCredit
            // 
            btnManageCredit.Location = new Point(385, 351);
            btnManageCredit.Name = "btnManageCredit";
            btnManageCredit.Size = new Size(114, 29);
            btnManageCredit.TabIndex = 2;
            btnManageCredit.Text = "افزایش اعتبار";
            btnManageCredit.UseVisualStyleBackColor = true;
            btnManageCredit.Click += btnManageCredit_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(222, 351);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 29);
            btnupdate.TabIndex = 3;
            btnupdate.Text = "به روزرسانی";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 38);
            label1.Name = "label1";
            label1.Size = new Size(229, 20);
            label1.TabIndex = 4;
            label1.Text = "تعداد کتاب های امانت گرفته شده : ";
            // 
            // txtCountBooks
            // 
            txtCountBooks.AutoSize = true;
            txtCountBooks.Location = new Point(288, 38);
            txtCountBooks.Name = "txtCountBooks";
            txtCountBooks.Size = new Size(43, 20);
            txtCountBooks.TabIndex = 5;
            txtCountBooks.Text = "تعداد";
            // 
            // button1
            // 
            button1.Location = new Point(43, 351);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "خروج";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { بازگشتبهصفحهورودToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // بازگشتبهصفحهورودToolStripMenuItem
            // 
            بازگشتبهصفحهورودToolStripMenuItem.Name = "بازگشتبهصفحهورودToolStripMenuItem";
            بازگشتبهصفحهورودToolStripMenuItem.Size = new Size(166, 24);
            بازگشتبهصفحهورودToolStripMenuItem.Text = "بازگشت به صفحه ورود";
            بازگشتبهصفحهورودToolStripMenuItem.Click += بازگشتبهصفحهورودToolStripMenuItem_Click;
            // 
            // UserMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtCountBooks);
            Controls.Add(label1);
            Controls.Add(btnupdate);
            Controls.Add(btnManageCredit);
            Controls.Add(btnRenew);
            Controls.Add(dataGridViewBorrows);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "UserMainForm";
            Text = "فرم امانات";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorrows).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBorrows;
        private Button btnRenew;
        private Button btnManageCredit;
        private Button btnupdate;
        private Label label1;
        private Label txtCountBooks;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem بازگشتبهصفحهورودToolStripMenuItem;
    }
}
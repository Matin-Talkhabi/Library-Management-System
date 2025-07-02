namespace library
{
    partial class BorrowBookForm
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
            label1 = new Label();
            btnBorrowBook = new Button();
            UserComboBox = new ComboBox();
            BookComboBox = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 87);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "اسم کاربر";
            // 
            // btnBorrowBook
            // 
            btnBorrowBook.Location = new Point(519, 302);
            btnBorrowBook.Name = "btnBorrowBook";
            btnBorrowBook.Size = new Size(94, 29);
            btnBorrowBook.TabIndex = 1;
            btnBorrowBook.Text = "امانت دهی";
            btnBorrowBook.UseVisualStyleBackColor = true;
            btnBorrowBook.Click += btnBorrowBook_Click;
            // 
            // UserComboBox
            // 
            UserComboBox.FormattingEnabled = true;
            UserComboBox.Location = new Point(180, 79);
            UserComboBox.Name = "UserComboBox";
            UserComboBox.Size = new Size(151, 28);
            UserComboBox.TabIndex = 2;
            // 
            // BookComboBox
            // 
            BookComboBox.FormattingEnabled = true;
            BookComboBox.Location = new Point(180, 177);
            BookComboBox.Name = "BookComboBox";
            BookComboBox.Size = new Size(151, 28);
            BookComboBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 185);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "اسم کتاب";
            // 
            // BorrowBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BookComboBox);
            Controls.Add(label2);
            Controls.Add(UserComboBox);
            Controls.Add(btnBorrowBook);
            Controls.Add(label1);
            Name = "BorrowBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "امانت";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBorrowBook;
        private ComboBox UserComboBox;
        private ComboBox BookComboBox;
        private Label label2;
    }
}
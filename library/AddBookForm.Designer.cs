namespace library
{
    partial class AddBookForm
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
            txtTitle = new TextBox();
            btnAddBook = new Button();
            txtAuthor = new TextBox();
            label2 = new Label();
            txtPublisher = new TextBox();
            label3 = new Label();
            txtYear = new TextBox();
            label4 = new Label();
            txtCopies = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 75);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "نام کتاب";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(167, 75);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(409, 366);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 29);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "اضافه کردن";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(167, 143);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 143);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 3;
            label2.Text = "نام نویسنده";
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(170, 202);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(125, 27);
            txtPublisher.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 205);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 5;
            label3.Text = "نام ناشر";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(167, 265);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 265);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 7;
            label4.Text = "سال انتشار";
            // 
            // txtCopies
            // 
            txtCopies.Location = new Point(167, 325);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new Size(125, 27);
            txtCopies.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 325);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 9;
            label5.Text = "تعداد نسخه";
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCopies);
            Controls.Add(label5);
            Controls.Add(txtYear);
            Controls.Add(label4);
            Controls.Add(txtPublisher);
            Controls.Add(label3);
            Controls.Add(txtAuthor);
            Controls.Add(label2);
            Controls.Add(btnAddBook);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Name = "AddBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافه کردن کتاب";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private Button btnAddBook;
        private TextBox txtAuthor;
        private Label label2;
        private TextBox txtPublisher;
        private Label label3;
        private TextBox txtYear;
        private Label label4;
        private TextBox txtCopies;
        private Label label5;
    }
}
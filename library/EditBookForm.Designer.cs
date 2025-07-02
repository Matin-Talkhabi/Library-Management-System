namespace library
{
    partial class EditBookForm
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
            txtCopies = new TextBox();
            label5 = new Label();
            txtPublicationYear = new TextBox();
            label4 = new Label();
            txtPublisher = new TextBox();
            label3 = new Label();
            txtAuthor = new TextBox();
            label2 = new Label();
            btnAddBook = new Button();
            txtTitle = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtCopies
            // 
            txtCopies.Location = new Point(170, 306);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new Size(125, 27);
            txtCopies.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 306);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 20;
            label5.Text = "تعداد نسخه";
            // 
            // txtPublicationYear
            // 
            txtPublicationYear.Location = new Point(170, 246);
            txtPublicationYear.Name = "txtPublicationYear";
            txtPublicationYear.Size = new Size(125, 27);
            txtPublicationYear.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 246);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 18;
            label4.Text = "سال انتشار";
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(173, 183);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(125, 27);
            txtPublisher.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 186);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 16;
            label3.Text = "نام ناشر";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(170, 124);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 124);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 14;
            label2.Text = "نام نویسنده";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(412, 347);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 29);
            btnAddBook.TabIndex = 13;
            btnAddBook.Text = "ویرایش";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(170, 56);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 56);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 11;
            label1.Text = "نام کتاب";
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCopies);
            Controls.Add(label5);
            Controls.Add(txtPublicationYear);
            Controls.Add(label4);
            Controls.Add(txtPublisher);
            Controls.Add(label3);
            Controls.Add(txtAuthor);
            Controls.Add(label2);
            Controls.Add(btnAddBook);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Name = "EditBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ویرایش کردن کتاب";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCopies;
        private Label label5;
        private TextBox txtPublicationYear;
        private Label label4;
        private TextBox txtPublisher;
        private Label label3;
        private TextBox txtAuthor;
        private Label label2;
        private Button btnAddBook;
        private TextBox txtTitle;
        private Label label1;
    }
}
namespace library
{
    partial class EditBorrowForm
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpReturnDate = new DateTimePicker();
            txtBookTitle = new TextBox();
            btnSave = new Button();
            dtpBorrowDate = new DateTimePicker();
            txtUsername = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 282);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 17;
            label4.Text = "تاریخ تحویل";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 219);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 16;
            label3.Text = "تاریخ دریافت";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 158);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 15;
            label2.Text = "اسم کتاب";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 99);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 14;
            label1.Text = "اسم کاربر";
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(229, 282);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(250, 27);
            dtpReturnDate.TabIndex = 13;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(229, 158);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(125, 27);
            txtBookTitle.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(578, 329);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "ثبت";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Location = new Point(229, 219);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(250, 27);
            dtpBorrowDate.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(229, 92);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 9;
            // 
            // EditBorrowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpReturnDate);
            Controls.Add(txtBookTitle);
            Controls.Add(btnSave);
            Controls.Add(dtpBorrowDate);
            Controls.Add(txtUsername);
            Name = "EditBorrowForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ویرایش کردن امانت";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpReturnDate;
        private TextBox txtBookTitle;
        private Button btnSave;
        private DateTimePicker dtpBorrowDate;
        private TextBox txtUsername;
    }
}
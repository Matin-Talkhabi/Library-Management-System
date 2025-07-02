namespace library
{
    partial class EditUserForm
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
            txtUsername = new TextBox();
            chkIsAdmin = new CheckBox();
            btnSave = new Button();
            txtCreatedBy = new TextBox();
            txtCredit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labal = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(130, 89);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 0;
            // 
            // chkIsAdmin
            // 
            chkIsAdmin.AutoSize = true;
            chkIsAdmin.Location = new Point(154, 248);
            chkIsAdmin.Name = "chkIsAdmin";
            chkIsAdmin.Size = new Size(67, 24);
            chkIsAdmin.TabIndex = 1;
            chkIsAdmin.Text = "ادمین";
            chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(391, 245);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "ذخیره";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtCreatedBy
            // 
            txtCreatedBy.Location = new Point(130, 191);
            txtCreatedBy.Name = "txtCreatedBy";
            txtCreatedBy.Size = new Size(125, 27);
            txtCreatedBy.TabIndex = 3;
            // 
            // txtCredit
            // 
            txtCredit.Location = new Point(130, 144);
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new Size(125, 27);
            txtCredit.TabIndex = 4;
            txtCredit.TextChanged += txtCredit_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 89);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 5;
            label1.Text = "نام کاربری";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 249);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "ادمین";
            // 
            // labal
            // 
            labal.AutoSize = true;
            labal.Location = new Point(38, 198);
            labal.Name = "labal";
            labal.Size = new Size(52, 20);
            labal.TabIndex = 7;
            labal.Text = "سازنده";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 144);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 8;
            label4.Text = "اعتبار";
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(labal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCredit);
            Controls.Add(txtCreatedBy);
            Controls.Add(btnSave);
            Controls.Add(chkIsAdmin);
            Controls.Add(txtUsername);
            Name = "EditUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ویرایش کاربر";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private CheckBox chkIsAdmin;
        private Button btnSave;
        private TextBox txtCreatedBy;
        private TextBox txtCredit;
        private Label label1;
        private Label label2;
        private Label labal;
        private Label label4;
    }
}
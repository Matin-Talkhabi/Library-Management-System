namespace library
{
    partial class addUserForm
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
            btnAddUser = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            chkIsAdmin = new CheckBox();
            txtCredit = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 79);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "نام کاربری";
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(415, 79);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(94, 29);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "ساختن";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(169, 76);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(169, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 141);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "رمز عبور";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 276);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 6;
            label3.Text = "ادمین";
            // 
            // chkIsAdmin
            // 
            chkIsAdmin.AutoSize = true;
            chkIsAdmin.Location = new Point(169, 276);
            chkIsAdmin.Name = "chkIsAdmin";
            chkIsAdmin.Size = new Size(67, 24);
            chkIsAdmin.TabIndex = 7;
            chkIsAdmin.Text = "ادمین";
            chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // txtCredit
            // 
            txtCredit.Location = new Point(169, 204);
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new Size(125, 27);
            txtCredit.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 207);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 8;
            label4.Text = "اعتبار";
            // 
            // addUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCredit);
            Controls.Add(label4);
            Controls.Add(chkIsAdmin);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(btnAddUser);
            Controls.Add(label1);
            Name = "addUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافه کردن کاربر";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddUser;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private CheckBox chkIsAdmin;
        private TextBox txtCredit;
        private Label label4;
    }
}
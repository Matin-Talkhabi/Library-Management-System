namespace library
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login = new Button();
            userNameInput = new TextBox();
            username = new Label();
            password = new Label();
            passwordInput = new TextBox();
            clear = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(548, 287);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 0;
            login.Text = "ورود";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // userNameInput
            // 
            userNameInput.Location = new Point(209, 95);
            userNameInput.Name = "userNameInput";
            userNameInput.Size = new Size(433, 27);
            userNameInput.TabIndex = 1;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(104, 95);
            username.Name = "username";
            username.Size = new Size(70, 20);
            username.TabIndex = 2;
            username.Text = "نام کاربری";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(104, 169);
            password.Name = "password";
            password.Size = new Size(48, 20);
            password.TabIndex = 4;
            password.Text = "پسورد";
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(209, 166);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(433, 27);
            passwordInput.TabIndex = 3;
            // 
            // clear
            // 
            clear.Location = new Point(327, 287);
            clear.Name = "clear";
            clear.Size = new Size(94, 29);
            clear.TabIndex = 6;
            clear.Text = "پاک کردن";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // exit
            // 
            exit.Location = new Point(104, 287);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 7;
            exit.Text = "خروج";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(clear);
            Controls.Add(password);
            Controls.Add(passwordInput);
            Controls.Add(username);
            Controls.Add(userNameInput);
            Controls.Add(login);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "صفحه ورود";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private TextBox userNameInput;
        private Label username;
        private Label password;
        private TextBox passwordInput;
        private Button clear;
        private Button exit;
    }
}

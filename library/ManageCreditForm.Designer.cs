namespace library
{
    partial class ManageCreditForm
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
            txtAddCredit = new TextBox();
            btnAddCredit = new Button();
            label2 = new Label();
            lblCredit = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 114);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "اعتبار";
            // 
            // txtAddCredit
            // 
            txtAddCredit.Location = new Point(183, 114);
            txtAddCredit.Name = "txtAddCredit";
            txtAddCredit.Size = new Size(125, 27);
            txtAddCredit.TabIndex = 1;
            // 
            // btnAddCredit
            // 
            btnAddCredit.Location = new Point(465, 114);
            btnAddCredit.Name = "btnAddCredit";
            btnAddCredit.Size = new Size(94, 29);
            btnAddCredit.TabIndex = 2;
            btnAddCredit.Text = "افزایش اعتبار";
            btnAddCredit.UseVisualStyleBackColor = true;
            btnAddCredit.Click += btnAddCredit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 34);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "اعتبار شما : ";
            // 
            // lblCredit
            // 
            lblCredit.AutoSize = true;
            lblCredit.Location = new Point(183, 34);
            lblCredit.Name = "lblCredit";
            lblCredit.Size = new Size(87, 20);
            lblCredit.TabIndex = 4;
            lblCredit.Text = "نمایش اعتبار";
            // 
            // ManageCreditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCredit);
            Controls.Add(label2);
            Controls.Add(btnAddCredit);
            Controls.Add(txtAddCredit);
            Controls.Add(label1);
            Name = "ManageCreditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "افزایش اعتبار";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAddCredit;
        private Button btnAddCredit;
        private Label label2;
        private Label lblCredit;
    }
}
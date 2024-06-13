namespace BankingApplicationInteractionForm
{
    partial class CreateAccountForm
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
            CreateAccountTitleLabel = new Label();
            BackToLoginButton = new Button();
            AccountOwnerEmailLabel = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            CreateNewAccountButton = new Button();
            SuspendLayout();
            // 
            // CreateAccountTitleLabel
            // 
            CreateAccountTitleLabel.AutoSize = true;
            CreateAccountTitleLabel.Font = new Font("Segoe UI", 20F);
            CreateAccountTitleLabel.Location = new Point(67, 9);
            CreateAccountTitleLabel.Name = "CreateAccountTitleLabel";
            CreateAccountTitleLabel.Size = new Size(258, 37);
            CreateAccountTitleLabel.TabIndex = 0;
            CreateAccountTitleLabel.Text = "Create New Account";
            // 
            // BackToLoginButton
            // 
            BackToLoginButton.Location = new Point(12, 9);
            BackToLoginButton.Name = "BackToLoginButton";
            BackToLoginButton.Size = new Size(47, 23);
            BackToLoginButton.TabIndex = 1;
            BackToLoginButton.Text = "Back";
            BackToLoginButton.UseVisualStyleBackColor = true;
            // 
            // AccountOwnerEmailLabel
            // 
            AccountOwnerEmailLabel.AutoSize = true;
            AccountOwnerEmailLabel.Location = new Point(12, 52);
            AccountOwnerEmailLabel.Name = "AccountOwnerEmailLabel";
            AccountOwnerEmailLabel.Size = new Size(39, 15);
            AccountOwnerEmailLabel.TabIndex = 2;
            AccountOwnerEmailLabel.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 3;
            label2.Text = "Account Balance:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 6;
            // 
            // CreateNewAccountButton
            // 
            CreateNewAccountButton.Location = new Point(90, 107);
            CreateNewAccountButton.Name = "CreateNewAccountButton";
            CreateNewAccountButton.Size = new Size(142, 46);
            CreateNewAccountButton.TabIndex = 7;
            CreateNewAccountButton.Text = "Create New Account";
            CreateNewAccountButton.UseVisualStyleBackColor = true;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 167);
            Controls.Add(CreateNewAccountButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(AccountOwnerEmailLabel);
            Controls.Add(BackToLoginButton);
            Controls.Add(CreateAccountTitleLabel);
            Name = "CreateAccountForm";
            Text = "Create New Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateAccountTitleLabel;
        private Button BackToLoginButton;
        private Label AccountOwnerEmailLabel;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button CreateNewAccountButton;
    }
}
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
            EmailInputTextbox = new TextBox();
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
            BackToLoginButton.Click += BackToLoginButton_Click;
            // 
            // AccountOwnerEmailLabel
            // 
            AccountOwnerEmailLabel.AutoSize = true;
            AccountOwnerEmailLabel.Location = new Point(22, 68);
            AccountOwnerEmailLabel.Name = "AccountOwnerEmailLabel";
            AccountOwnerEmailLabel.Size = new Size(39, 15);
            AccountOwnerEmailLabel.TabIndex = 2;
            AccountOwnerEmailLabel.Text = "Email:";
            // 
            // EmailInputTextbox
            // 
            EmailInputTextbox.Location = new Point(67, 65);
            EmailInputTextbox.Name = "EmailInputTextbox";
            EmailInputTextbox.Size = new Size(253, 23);
            EmailInputTextbox.TabIndex = 5;
            // 
            // CreateNewAccountButton
            // 
            CreateNewAccountButton.Location = new Point(90, 107);
            CreateNewAccountButton.Name = "CreateNewAccountButton";
            CreateNewAccountButton.Size = new Size(142, 46);
            CreateNewAccountButton.TabIndex = 7;
            CreateNewAccountButton.Text = "Create New Account";
            CreateNewAccountButton.UseVisualStyleBackColor = true;
            CreateNewAccountButton.Click += CreateNewAccountButton_Click;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 167);
            Controls.Add(CreateNewAccountButton);
            Controls.Add(EmailInputTextbox);
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
        private TextBox EmailInputTextbox;
        private Button CreateNewAccountButton;
    }
}
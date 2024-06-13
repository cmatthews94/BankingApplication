namespace BankingApplicationInteractionForm
{
    partial class LoggedInUserForm
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
            LoggedInUserTitleLabel = new Label();
            LoggedInUserDisplayLabel = new Label();
            AccountNumberLabel = new Label();
            AccountNumberDisplayLabel = new Label();
            AccountBalanceDisplayLabel = new Label();
            AccountBalanceLabel = new Label();
            LogoutButton = new Button();
            LoggedInUserEmailLabel = new Label();
            LoggedInUserEmailDisplayLabel = new Label();
            SuspendLayout();
            // 
            // LoggedInUserTitleLabel
            // 
            LoggedInUserTitleLabel.AutoSize = true;
            LoggedInUserTitleLabel.Location = new Point(12, 18);
            LoggedInUserTitleLabel.Name = "LoggedInUserTitleLabel";
            LoggedInUserTitleLabel.Size = new Size(102, 15);
            LoggedInUserTitleLabel.TabIndex = 0;
            LoggedInUserTitleLabel.Text = "Logged in User Id:";
            // 
            // LoggedInUserDisplayLabel
            // 
            LoggedInUserDisplayLabel.AutoSize = true;
            LoggedInUserDisplayLabel.Font = new Font("Segoe UI", 20F);
            LoggedInUserDisplayLabel.Location = new Point(120, 9);
            LoggedInUserDisplayLabel.Name = "LoggedInUserDisplayLabel";
            LoggedInUserDisplayLabel.Size = new Size(272, 37);
            LoggedInUserDisplayLabel.TabIndex = 1;
            LoggedInUserDisplayLabel.Text = "*UserId Display Here*";
            // 
            // AccountNumberLabel
            // 
            AccountNumberLabel.AutoSize = true;
            AccountNumberLabel.Location = new Point(12, 91);
            AccountNumberLabel.Name = "AccountNumberLabel";
            AccountNumberLabel.Size = new Size(102, 15);
            AccountNumberLabel.TabIndex = 2;
            AccountNumberLabel.Text = "Account Number:";
            // 
            // AccountNumberDisplayLabel
            // 
            AccountNumberDisplayLabel.AutoSize = true;
            AccountNumberDisplayLabel.Location = new Point(120, 91);
            AccountNumberDisplayLabel.Name = "AccountNumberDisplayLabel";
            AccountNumberDisplayLabel.Size = new Size(137, 15);
            AccountNumberDisplayLabel.TabIndex = 3;
            AccountNumberDisplayLabel.Text = "*Account Number Here*";
            // 
            // AccountBalanceDisplayLabel
            // 
            AccountBalanceDisplayLabel.AutoSize = true;
            AccountBalanceDisplayLabel.Location = new Point(120, 106);
            AccountBalanceDisplayLabel.Name = "AccountBalanceDisplayLabel";
            AccountBalanceDisplayLabel.Size = new Size(134, 15);
            AccountBalanceDisplayLabel.TabIndex = 4;
            AccountBalanceDisplayLabel.Text = "*Account Balance Here*";
            // 
            // AccountBalanceLabel
            // 
            AccountBalanceLabel.AutoSize = true;
            AccountBalanceLabel.Location = new Point(12, 106);
            AccountBalanceLabel.Name = "AccountBalanceLabel";
            AccountBalanceLabel.Size = new Size(51, 15);
            AccountBalanceLabel.TabIndex = 5;
            AccountBalanceLabel.Text = "Balance:";
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(299, 141);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(75, 23);
            LogoutButton.TabIndex = 6;
            LogoutButton.Text = "Log Out";
            LogoutButton.UseVisualStyleBackColor = true;
            // 
            // LoggedInUserEmailLabel
            // 
            LoggedInUserEmailLabel.AutoSize = true;
            LoggedInUserEmailLabel.Location = new Point(12, 76);
            LoggedInUserEmailLabel.Name = "LoggedInUserEmailLabel";
            LoggedInUserEmailLabel.Size = new Size(65, 15);
            LoggedInUserEmailLabel.TabIndex = 7;
            LoggedInUserEmailLabel.Text = "User Email:";
            // 
            // LoggedInUserEmailDisplayLabel
            // 
            LoggedInUserEmailDisplayLabel.AutoSize = true;
            LoggedInUserEmailDisplayLabel.Location = new Point(120, 76);
            LoggedInUserEmailDisplayLabel.Name = "LoggedInUserEmailDisplayLabel";
            LoggedInUserEmailDisplayLabel.Size = new Size(100, 15);
            LoggedInUserEmailDisplayLabel.TabIndex = 8;
            LoggedInUserEmailDisplayLabel.Text = "*User Email Here*";
            // 
            // LoggedInUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 175);
            Controls.Add(LoggedInUserEmailDisplayLabel);
            Controls.Add(LoggedInUserEmailLabel);
            Controls.Add(LogoutButton);
            Controls.Add(AccountBalanceLabel);
            Controls.Add(AccountBalanceDisplayLabel);
            Controls.Add(AccountNumberDisplayLabel);
            Controls.Add(AccountNumberLabel);
            Controls.Add(LoggedInUserDisplayLabel);
            Controls.Add(LoggedInUserTitleLabel);
            Name = "LoggedInUserForm";
            Text = "Logged In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoggedInUserTitleLabel;
        private Label LoggedInUserDisplayLabel;
        private Label AccountNumberLabel;
        private Label AccountNumberDisplayLabel;
        private Label AccountBalanceDisplayLabel;
        private Label AccountBalanceLabel;
        private Button LogoutButton;
        private Label LoggedInUserEmailLabel;
        private Label LoggedInUserEmailDisplayLabel;
    }
}
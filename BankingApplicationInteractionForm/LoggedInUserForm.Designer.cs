﻿namespace BankingApplicationInteractionForm
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
            LoggedInUserEmailTitleLabel = new Label();
            LoggedInUserEmailDisplayLabel = new Label();
            Account1NumberLabel = new Label();
            Account1NumberDisplayLabel = new Label();
            Account1BalanceDisplayLabel = new Label();
            Account1BalanceLabel = new Label();
            LogoutButton = new Button();
            LoggedInUserIdLabel = new Label();
            LoggedInEmailDisplayLabel = new Label();
            Account2NumberLabel = new Label();
            Account2BalanceLabel = new Label();
            Account2NumberDisplayLabel = new Label();
            Account2BalanceDisplayLabel = new Label();
            Account3NumberLabel = new Label();
            Account3NumberDisplayLabel = new Label();
            Account3BalanceLabel = new Label();
            Account3BalanceDisplayLabel = new Label();
            TransactionConfirmButton = new Button();
            MakeTransactionLabel = new Label();
            PickAccountCombobox = new ComboBox();
            PickAccountLabel = new Label();
            TranscationTypeLabel = new Label();
            TransactionTypeCombobox = new ComboBox();
            TransactionAmountLabel = new Label();
            TransactionAmountTextbox = new TextBox();
            ChangePasswordButton = new Button();
            SuspendLayout();
            // 
            // LoggedInUserEmailTitleLabel
            // 
            LoggedInUserEmailTitleLabel.AutoSize = true;
            LoggedInUserEmailTitleLabel.Location = new Point(12, 18);
            LoggedInUserEmailTitleLabel.Name = "LoggedInUserEmailTitleLabel";
            LoggedInUserEmailTitleLabel.Size = new Size(0, 15);
            LoggedInUserEmailTitleLabel.TabIndex = 0;
            // 
            // LoggedInUserEmailDisplayLabel
            // 
            LoggedInUserEmailDisplayLabel.AutoSize = true;
            LoggedInUserEmailDisplayLabel.Font = new Font("Segoe UI", 20F);
            LoggedInUserEmailDisplayLabel.Location = new Point(12, 9);
            LoggedInUserEmailDisplayLabel.Name = "LoggedInUserEmailDisplayLabel";
            LoggedInUserEmailDisplayLabel.Size = new Size(261, 37);
            LoggedInUserEmailDisplayLabel.TabIndex = 1;
            LoggedInUserEmailDisplayLabel.Text = "*Email Display Here*";
            // 
            // Account1NumberLabel
            // 
            Account1NumberLabel.AutoSize = true;
            Account1NumberLabel.Location = new Point(23, 52);
            Account1NumberLabel.Name = "Account1NumberLabel";
            Account1NumberLabel.Size = new Size(102, 15);
            Account1NumberLabel.TabIndex = 2;
            Account1NumberLabel.Text = "Account Number:";
            Account1NumberLabel.Visible = false;
            // 
            // Account1NumberDisplayLabel
            // 
            Account1NumberDisplayLabel.AutoSize = true;
            Account1NumberDisplayLabel.Location = new Point(131, 52);
            Account1NumberDisplayLabel.Name = "Account1NumberDisplayLabel";
            Account1NumberDisplayLabel.Size = new Size(62, 15);
            Account1NumberDisplayLabel.TabIndex = 3;
            Account1NumberDisplayLabel.Text = "acc num 1";
            Account1NumberDisplayLabel.Visible = false;
            // 
            // Account1BalanceDisplayLabel
            // 
            Account1BalanceDisplayLabel.AutoSize = true;
            Account1BalanceDisplayLabel.Location = new Point(131, 67);
            Account1BalanceDisplayLabel.Name = "Account1BalanceDisplayLabel";
            Account1BalanceDisplayLabel.Size = new Size(53, 15);
            Account1BalanceDisplayLabel.TabIndex = 4;
            Account1BalanceDisplayLabel.Text = "acc bal 1";
            Account1BalanceDisplayLabel.Visible = false;
            // 
            // Account1BalanceLabel
            // 
            Account1BalanceLabel.AutoSize = true;
            Account1BalanceLabel.Location = new Point(23, 67);
            Account1BalanceLabel.Name = "Account1BalanceLabel";
            Account1BalanceLabel.Size = new Size(51, 15);
            Account1BalanceLabel.TabIndex = 5;
            Account1BalanceLabel.Text = "Balance:";
            Account1BalanceLabel.Visible = false;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(50, 310);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(75, 39);
            LogoutButton.TabIndex = 6;
            LogoutButton.Text = "Log Out";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // LoggedInUserIdLabel
            // 
            LoggedInUserIdLabel.AutoSize = true;
            LoggedInUserIdLabel.Location = new Point(12, 33);
            LoggedInUserIdLabel.Name = "LoggedInUserIdLabel";
            LoggedInUserIdLabel.Size = new Size(0, 15);
            LoggedInUserIdLabel.TabIndex = 7;
            // 
            // LoggedInEmailDisplayLabel
            // 
            LoggedInEmailDisplayLabel.AutoSize = true;
            LoggedInEmailDisplayLabel.Location = new Point(12, 33);
            LoggedInEmailDisplayLabel.Name = "LoggedInEmailDisplayLabel";
            LoggedInEmailDisplayLabel.Size = new Size(0, 15);
            LoggedInEmailDisplayLabel.TabIndex = 8;
            // 
            // Account2NumberLabel
            // 
            Account2NumberLabel.AutoSize = true;
            Account2NumberLabel.Location = new Point(23, 82);
            Account2NumberLabel.Name = "Account2NumberLabel";
            Account2NumberLabel.Size = new Size(102, 15);
            Account2NumberLabel.TabIndex = 9;
            Account2NumberLabel.Text = "Account Number:";
            Account2NumberLabel.Visible = false;
            // 
            // Account2BalanceLabel
            // 
            Account2BalanceLabel.AutoSize = true;
            Account2BalanceLabel.Location = new Point(23, 97);
            Account2BalanceLabel.Name = "Account2BalanceLabel";
            Account2BalanceLabel.Size = new Size(51, 15);
            Account2BalanceLabel.TabIndex = 10;
            Account2BalanceLabel.Text = "Balance:";
            Account2BalanceLabel.Visible = false;
            // 
            // Account2NumberDisplayLabel
            // 
            Account2NumberDisplayLabel.AutoSize = true;
            Account2NumberDisplayLabel.Location = new Point(131, 82);
            Account2NumberDisplayLabel.Name = "Account2NumberDisplayLabel";
            Account2NumberDisplayLabel.Size = new Size(62, 15);
            Account2NumberDisplayLabel.TabIndex = 11;
            Account2NumberDisplayLabel.Text = "acc num 2";
            Account2NumberDisplayLabel.Visible = false;
            // 
            // Account2BalanceDisplayLabel
            // 
            Account2BalanceDisplayLabel.AutoSize = true;
            Account2BalanceDisplayLabel.Location = new Point(131, 97);
            Account2BalanceDisplayLabel.Name = "Account2BalanceDisplayLabel";
            Account2BalanceDisplayLabel.Size = new Size(53, 15);
            Account2BalanceDisplayLabel.TabIndex = 12;
            Account2BalanceDisplayLabel.Text = "acc bal 2";
            Account2BalanceDisplayLabel.Visible = false;
            // 
            // Account3NumberLabel
            // 
            Account3NumberLabel.AutoSize = true;
            Account3NumberLabel.Location = new Point(23, 112);
            Account3NumberLabel.Name = "Account3NumberLabel";
            Account3NumberLabel.Size = new Size(102, 15);
            Account3NumberLabel.TabIndex = 13;
            Account3NumberLabel.Text = "Account Number:";
            Account3NumberLabel.Visible = false;
            // 
            // Account3NumberDisplayLabel
            // 
            Account3NumberDisplayLabel.AutoSize = true;
            Account3NumberDisplayLabel.Location = new Point(131, 112);
            Account3NumberDisplayLabel.Name = "Account3NumberDisplayLabel";
            Account3NumberDisplayLabel.Size = new Size(62, 15);
            Account3NumberDisplayLabel.TabIndex = 14;
            Account3NumberDisplayLabel.Text = "acc num 3";
            Account3NumberDisplayLabel.Visible = false;
            // 
            // Account3BalanceLabel
            // 
            Account3BalanceLabel.AutoSize = true;
            Account3BalanceLabel.Location = new Point(23, 127);
            Account3BalanceLabel.Name = "Account3BalanceLabel";
            Account3BalanceLabel.Size = new Size(51, 15);
            Account3BalanceLabel.TabIndex = 15;
            Account3BalanceLabel.Text = "Balance:";
            Account3BalanceLabel.Visible = false;
            // 
            // Account3BalanceDisplayLabel
            // 
            Account3BalanceDisplayLabel.AutoSize = true;
            Account3BalanceDisplayLabel.Location = new Point(131, 127);
            Account3BalanceDisplayLabel.Name = "Account3BalanceDisplayLabel";
            Account3BalanceDisplayLabel.Size = new Size(53, 15);
            Account3BalanceDisplayLabel.TabIndex = 16;
            Account3BalanceDisplayLabel.Text = "acc bal 3";
            Account3BalanceDisplayLabel.Visible = false;
            // 
            // TransactionConfirmButton
            // 
            TransactionConfirmButton.Location = new Point(162, 263);
            TransactionConfirmButton.Name = "TransactionConfirmButton";
            TransactionConfirmButton.Size = new Size(100, 24);
            TransactionConfirmButton.TabIndex = 17;
            TransactionConfirmButton.Text = "Confirm";
            TransactionConfirmButton.UseVisualStyleBackColor = true;
            TransactionConfirmButton.Click += TransactionConfirmButton_Click;
            // 
            // MakeTransactionLabel
            // 
            MakeTransactionLabel.AutoSize = true;
            MakeTransactionLabel.Font = new Font("Segoe UI", 20F);
            MakeTransactionLabel.Location = new Point(12, 166);
            MakeTransactionLabel.Name = "MakeTransactionLabel";
            MakeTransactionLabel.Size = new Size(162, 37);
            MakeTransactionLabel.TabIndex = 18;
            MakeTransactionLabel.Text = "Transactions";
            // 
            // PickAccountCombobox
            // 
            PickAccountCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            PickAccountCombobox.FormattingEnabled = true;
            PickAccountCombobox.Location = new Point(23, 221);
            PickAccountCombobox.Name = "PickAccountCombobox";
            PickAccountCombobox.Size = new Size(121, 23);
            PickAccountCombobox.TabIndex = 19;
            // 
            // PickAccountLabel
            // 
            PickAccountLabel.AutoSize = true;
            PickAccountLabel.Location = new Point(23, 203);
            PickAccountLabel.Name = "PickAccountLabel";
            PickAccountLabel.Size = new Size(92, 15);
            PickAccountLabel.TabIndex = 20;
            PickAccountLabel.Text = "Which account?";
            // 
            // TranscationTypeLabel
            // 
            TranscationTypeLabel.AutoSize = true;
            TranscationTypeLabel.Location = new Point(23, 247);
            TranscationTypeLabel.Name = "TranscationTypeLabel";
            TranscationTypeLabel.Size = new Size(129, 15);
            TranscationTypeLabel.TabIndex = 21;
            TranscationTypeLabel.Text = "Deposit or Withdrawal?";
            // 
            // TransactionTypeCombobox
            // 
            TransactionTypeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            TransactionTypeCombobox.FormattingEnabled = true;
            TransactionTypeCombobox.Location = new Point(23, 265);
            TransactionTypeCombobox.Name = "TransactionTypeCombobox";
            TransactionTypeCombobox.Size = new Size(121, 23);
            TransactionTypeCombobox.TabIndex = 22;
            // 
            // TransactionAmountLabel
            // 
            TransactionAmountLabel.AutoSize = true;
            TransactionAmountLabel.Location = new Point(187, 203);
            TransactionAmountLabel.Name = "TransactionAmountLabel";
            TransactionAmountLabel.Size = new Size(56, 15);
            TransactionAmountLabel.TabIndex = 23;
            TransactionAmountLabel.Text = "Amount?";
            // 
            // TransactionAmountTextbox
            // 
            TransactionAmountTextbox.Location = new Point(162, 221);
            TransactionAmountTextbox.Name = "TransactionAmountTextbox";
            TransactionAmountTextbox.Size = new Size(100, 23);
            TransactionAmountTextbox.TabIndex = 24;
            TransactionAmountTextbox.Validating += TransactionAmountTextbox_Validating;
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.Location = new Point(131, 310);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.Size = new Size(75, 39);
            ChangePasswordButton.TabIndex = 25;
            ChangePasswordButton.Text = "Change Password";
            ChangePasswordButton.UseVisualStyleBackColor = true;
            ChangePasswordButton.Click += ChangePasswordButton_Click;
            // 
            // LoggedInUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 386);
            Controls.Add(ChangePasswordButton);
            Controls.Add(TransactionAmountTextbox);
            Controls.Add(TransactionAmountLabel);
            Controls.Add(TransactionTypeCombobox);
            Controls.Add(TranscationTypeLabel);
            Controls.Add(PickAccountLabel);
            Controls.Add(PickAccountCombobox);
            Controls.Add(MakeTransactionLabel);
            Controls.Add(TransactionConfirmButton);
            Controls.Add(Account3BalanceDisplayLabel);
            Controls.Add(Account3BalanceLabel);
            Controls.Add(Account3NumberDisplayLabel);
            Controls.Add(Account3NumberLabel);
            Controls.Add(Account2BalanceDisplayLabel);
            Controls.Add(Account2NumberDisplayLabel);
            Controls.Add(Account2BalanceLabel);
            Controls.Add(Account2NumberLabel);
            Controls.Add(LoggedInEmailDisplayLabel);
            Controls.Add(LoggedInUserIdLabel);
            Controls.Add(LogoutButton);
            Controls.Add(Account1BalanceLabel);
            Controls.Add(Account1BalanceDisplayLabel);
            Controls.Add(Account1NumberDisplayLabel);
            Controls.Add(Account1NumberLabel);
            Controls.Add(LoggedInUserEmailDisplayLabel);
            Controls.Add(LoggedInUserEmailTitleLabel);
            Name = "LoggedInUserForm";
            Text = "Logged In";
            Load += LoggedInUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoggedInUserTitleLabel;
        private Label LoggedInUserDisplayLabel;
        private Label Account1NumberLabel;
        private Label Account1NumberDisplayLabel;
        private Label Account1BalanceDisplayLabel;
        private Label Account1BalanceLabel;
        private Button LogoutButton;
        private Label LoggedInUserEmailLabel;
        private Label LoggedInUserEmailDisplayLabel;
        private Label LoggedInEmailDisplayLabel;
        private Label LoggedInUserEmailDisplayLabel1;
        private Label LoggedInUserEmailTitleLabel;
        private Label LoggedInUserIdLabel;
        private Label Account2NumberLabel;
        private Label Account2BalanceLabel;
        private Label Account2NumberDisplayLabel;
        private Label Account2BalanceDisplayLabel;
        private Label Account3NumberLabel;
        private Label Account3NumberDisplayLabel;
        private Label Account3BalanceLabel;
        private Label Account3BalanceDisplayLabel;
        private Button TransactionConfirmButton;
        private Label MakeTransactionLabel;
        private ComboBox PickAccountCombobox;
        private Label PickAccountLabel;
        private Label TranscationTypeLabel;
        private ComboBox TransactionTypeCombobox;
        private Label TransactionAmountLabel;
        private TextBox TransactionAmountTextbox;
        private Button ChangePasswordButton;
    }
}
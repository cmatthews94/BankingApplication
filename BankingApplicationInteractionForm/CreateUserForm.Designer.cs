namespace BankingApplicationInteractionForm
{
    partial class CreateUserForm
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
            EmailInputTextbox = new TextBox();
            CreateUserTitleLabel = new Label();
            CreateUserEmailLabel = new Label();
            PasswordInputTextbox = new TextBox();
            CreateUserPasswordLabel = new Label();
            CreateUserButton = new Button();
            label1 = new Label();
            BacktoLoginButton = new Button();
            SuspendLayout();
            // 
            // EmailInputTextbox
            // 
            EmailInputTextbox.Location = new Point(112, 49);
            EmailInputTextbox.Name = "EmailInputTextbox";
            EmailInputTextbox.Size = new Size(192, 23);
            EmailInputTextbox.TabIndex = 0;
            // 
            // CreateUserTitleLabel
            // 
            CreateUserTitleLabel.AutoSize = true;
            CreateUserTitleLabel.Font = new Font("Segoe UI", 20F);
            CreateUserTitleLabel.Location = new Point(99, 9);
            CreateUserTitleLabel.Name = "CreateUserTitleLabel";
            CreateUserTitleLabel.Size = new Size(215, 37);
            CreateUserTitleLabel.TabIndex = 2;
            CreateUserTitleLabel.Text = "Create New User";
            // 
            // CreateUserEmailLabel
            // 
            CreateUserEmailLabel.AutoSize = true;
            CreateUserEmailLabel.Location = new Point(12, 52);
            CreateUserEmailLabel.Name = "CreateUserEmailLabel";
            CreateUserEmailLabel.Size = new Size(84, 15);
            CreateUserEmailLabel.TabIndex = 3;
            CreateUserEmailLabel.Text = "Email Address:";
            // 
            // PasswordInputTextbox
            // 
            PasswordInputTextbox.Location = new Point(112, 78);
            PasswordInputTextbox.Name = "PasswordInputTextbox";
            PasswordInputTextbox.Size = new Size(192, 23);
            PasswordInputTextbox.TabIndex = 4;
            // 
            // CreateUserPasswordLabel
            // 
            CreateUserPasswordLabel.AutoSize = true;
            CreateUserPasswordLabel.Location = new Point(12, 81);
            CreateUserPasswordLabel.Name = "CreateUserPasswordLabel";
            CreateUserPasswordLabel.Size = new Size(60, 15);
            CreateUserPasswordLabel.TabIndex = 5;
            CreateUserPasswordLabel.Text = "Password:";
            // 
            // CreateUserButton
            // 
            CreateUserButton.Location = new Point(112, 144);
            CreateUserButton.Name = "CreateUserButton";
            CreateUserButton.Size = new Size(92, 39);
            CreateUserButton.TabIndex = 6;
            CreateUserButton.Text = "Create User";
            CreateUserButton.UseVisualStyleBackColor = true;
            CreateUserButton.Click += CreateUserButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(310, 15);
            label1.TabIndex = 7;
            label1.Text = "Note: new users are always generated with a new account";
            // 
            // BacktoLoginButton
            // 
            BacktoLoginButton.Location = new Point(12, 9);
            BacktoLoginButton.Name = "BacktoLoginButton";
            BacktoLoginButton.Size = new Size(49, 20);
            BacktoLoginButton.TabIndex = 8;
            BacktoLoginButton.Text = "Back";
            BacktoLoginButton.UseVisualStyleBackColor = true;
            BacktoLoginButton.Click += BacktoLoginButton_Click;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 195);
            Controls.Add(BacktoLoginButton);
            Controls.Add(label1);
            Controls.Add(CreateUserButton);
            Controls.Add(CreateUserPasswordLabel);
            Controls.Add(PasswordInputTextbox);
            Controls.Add(CreateUserEmailLabel);
            Controls.Add(CreateUserTitleLabel);
            Controls.Add(EmailInputTextbox);
            Name = "CreateUserForm";
            Text = "Create New User ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailInputTextbox;
        private Label CreateUserTitleLabel;
        private Label CreateUserEmailLabel;
        private TextBox PasswordInputTextbox;
        private Label CreateUserPasswordLabel;
        private Button CreateUserButton;
        private Label label1;
        private Button BacktoLoginButton;
    }
}
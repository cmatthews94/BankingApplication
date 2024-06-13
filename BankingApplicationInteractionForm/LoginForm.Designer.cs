namespace BankingApplicationInteractionForm
{
    partial class LoginForm
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
            CreateNewUserButton = new Button();
            CreateNewAccountButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LoginEmailLabel = new Label();
            LoginPasswordLabel = new Label();
            LoginButton = new Button();
            ExistingUserLoginLabel = new Label();
            SuspendLayout();
            // 
            // CreateNewUserButton
            // 
            CreateNewUserButton.Location = new Point(12, 12);
            CreateNewUserButton.Name = "CreateNewUserButton";
            CreateNewUserButton.Size = new Size(152, 55);
            CreateNewUserButton.TabIndex = 5;
            CreateNewUserButton.Text = "Create New User";
            CreateNewUserButton.UseVisualStyleBackColor = true;
            CreateNewUserButton.Click += CreateNewUserButton_Click;
            // 
            // CreateNewAccountButton
            // 
            CreateNewAccountButton.Location = new Point(170, 12);
            CreateNewAccountButton.Name = "CreateNewAccountButton";
            CreateNewAccountButton.Size = new Size(152, 55);
            CreateNewAccountButton.TabIndex = 6;
            CreateNewAccountButton.Text = "Create New Account";
            CreateNewAccountButton.UseVisualStyleBackColor = true;
            CreateNewAccountButton.Click += CreateNewAccountButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(95, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 23);
            textBox2.TabIndex = 8;
            // 
            // LoginEmailLabel
            // 
            LoginEmailLabel.AutoSize = true;
            LoginEmailLabel.Location = new Point(50, 113);
            LoginEmailLabel.Name = "LoginEmailLabel";
            LoginEmailLabel.Size = new Size(39, 15);
            LoginEmailLabel.TabIndex = 9;
            LoginEmailLabel.Text = "Email:";
            // 
            // LoginPasswordLabel
            // 
            LoginPasswordLabel.AutoSize = true;
            LoginPasswordLabel.Location = new Point(29, 145);
            LoginPasswordLabel.Name = "LoginPasswordLabel";
            LoginPasswordLabel.Size = new Size(60, 15);
            LoginPasswordLabel.TabIndex = 10;
            LoginPasswordLabel.Text = "Password:";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(128, 171);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 11;
            LoginButton.Text = "Log in";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // ExistingUserLoginLabel
            // 
            ExistingUserLoginLabel.AutoSize = true;
            ExistingUserLoginLabel.Location = new Point(107, 84);
            ExistingUserLoginLabel.Name = "ExistingUserLoginLabel";
            ExistingUserLoginLabel.Size = new Size(107, 15);
            ExistingUserLoginLabel.TabIndex = 12;
            ExistingUserLoginLabel.Text = "Existing User Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 209);
            Controls.Add(ExistingUserLoginLabel);
            Controls.Add(LoginButton);
            Controls.Add(LoginPasswordLabel);
            Controls.Add(LoginEmailLabel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(CreateNewAccountButton);
            Controls.Add(CreateNewUserButton);
            Name = "LoginForm";
            Text = "Bank Application Initial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CreateNewUserButton;
        private Button CreateNewAccountButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label LoginEmailLabel;
        private Label LoginPasswordLabel;
        private Button LoginButton;
        private Label ExistingUserLoginLabel;
    }
}

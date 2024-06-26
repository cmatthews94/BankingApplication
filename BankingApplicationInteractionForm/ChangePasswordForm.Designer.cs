namespace BankingApplicationInteractionForm
{
    partial class ChangePasswordForm
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
            ChangePasswordLabel = new Label();
            CurrentPasswordLabel = new Label();
            CurrentPasswordTextbox = new TextBox();
            NewPasswordTextbox = new TextBox();
            SubmitChangePasswordButton = new Button();
            CancelPasswordChangeButton = new Button();
            SuspendLayout();
            // 
            // ChangePasswordLabel
            // 
            ChangePasswordLabel.AutoSize = true;
            ChangePasswordLabel.Location = new Point(12, 53);
            ChangePasswordLabel.Name = "ChangePasswordLabel";
            ChangePasswordLabel.Size = new Size(124, 15);
            ChangePasswordLabel.TabIndex = 0;
            ChangePasswordLabel.Text = "Enter a new password:";
            // 
            // CurrentPasswordLabel
            // 
            CurrentPasswordLabel.AutoSize = true;
            CurrentPasswordLabel.Location = new Point(12, 9);
            CurrentPasswordLabel.Name = "CurrentPasswordLabel";
            CurrentPasswordLabel.Size = new Size(158, 15);
            CurrentPasswordLabel.TabIndex = 1;
            CurrentPasswordLabel.Text = "Enter your current password:";
            // 
            // CurrentPasswordTextbox
            // 
            CurrentPasswordTextbox.Location = new Point(12, 27);
            CurrentPasswordTextbox.Name = "CurrentPasswordTextbox";
            CurrentPasswordTextbox.Size = new Size(220, 23);
            CurrentPasswordTextbox.TabIndex = 2;
            // 
            // NewPasswordTextbox
            // 
            NewPasswordTextbox.Location = new Point(12, 71);
            NewPasswordTextbox.Name = "NewPasswordTextbox";
            NewPasswordTextbox.Size = new Size(220, 23);
            NewPasswordTextbox.TabIndex = 3;
            // 
            // SubmitChangePasswordButton
            // 
            SubmitChangePasswordButton.Location = new Point(117, 100);
            SubmitChangePasswordButton.Name = "SubmitChangePasswordButton";
            SubmitChangePasswordButton.Size = new Size(115, 25);
            SubmitChangePasswordButton.TabIndex = 4;
            SubmitChangePasswordButton.Text = "Update Password";
            SubmitChangePasswordButton.UseVisualStyleBackColor = true;
            SubmitChangePasswordButton.Click += SubmitChangePasswordButton_Click;
            // 
            // CancelPasswordChangeButton
            // 
            CancelPasswordChangeButton.Location = new Point(12, 100);
            CancelPasswordChangeButton.Name = "CancelPasswordChangeButton";
            CancelPasswordChangeButton.Size = new Size(80, 25);
            CancelPasswordChangeButton.TabIndex = 5;
            CancelPasswordChangeButton.Text = "Cancel";
            CancelPasswordChangeButton.UseVisualStyleBackColor = true;
            CancelPasswordChangeButton.Click += CancelPasswordChangeButton_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 143);
            Controls.Add(CancelPasswordChangeButton);
            Controls.Add(SubmitChangePasswordButton);
            Controls.Add(NewPasswordTextbox);
            Controls.Add(CurrentPasswordTextbox);
            Controls.Add(CurrentPasswordLabel);
            Controls.Add(ChangePasswordLabel);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChangePasswordLabel;
        private Label CurrentPasswordLabel;
        private TextBox CurrentPasswordTextbox;
        private TextBox NewPasswordTextbox;
        private Button SubmitChangePasswordButton;
        private Button CancelPasswordChangeButton;
    }
}
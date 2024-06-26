using BankingApplication.Interfaces;
using BankingApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplicationInteractionForm
{
    public partial class ChangePasswordForm : Form
    {
        private readonly IBankUserService _bankUserService;
        private readonly IPasswordHashingService _passwordHashingService;

        public BankUser _userDetails;
        public ChangePasswordForm(IBankUserService bankUserService, IPasswordHashingService passwordHashingService)
        {
            InitializeComponent();
            _bankUserService = bankUserService;
            _passwordHashingService = passwordHashingService;
        }

        private void SubmitChangePasswordButton_Click(object sender, EventArgs e)
        {
            var result = _passwordHashingService.VerifyLoginDetails(_userDetails.Password, CurrentPasswordTextbox.Text);
            if (!result)
            {
               MessageBox.Show("current password is incorrect");
                return;
            }

            _bankUserService.ChangeUserPassword(_userDetails.EmailAddress, NewPasswordTextbox.Text);
            MessageBox.Show("password changed succesfully");
            this.Close();
        }

        private void CancelPasswordChangeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

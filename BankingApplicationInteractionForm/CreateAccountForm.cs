using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingApplication.Interfaces;
using BankingApplication.LogicClasses;

namespace BankingApplicationInteractionForm
{
    public partial class CreateAccountForm : Form
    {
        private readonly IBankUserService _bankUserService;
        private readonly IBankAccountService _bankAccountActions;
        public CreateAccountForm(IBankUserService bankUserService, IBankAccountService bankAccountActions)
        {
            InitializeComponent();
            _bankUserService = bankUserService;
            _bankAccountActions = bankAccountActions;
        }

        private void CreateNewAccountButton_Click(object sender, EventArgs e)
        {

            var locatedUser = _bankUserService.GetUserByEmail(EmailInputTextbox.Text);
            if (locatedUser == null)
            {
                MessageBox.Show($"no user found for {EmailInputTextbox.Text}");
            }
            else
            {
                _bankAccountActions.CreateNewAccount(locatedUser.UserId);

                MessageBox.Show($"Account Created for {EmailInputTextbox.Text}", "", MessageBoxButtons.OK);
                EmailInputTextbox.Text = "";
            }
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

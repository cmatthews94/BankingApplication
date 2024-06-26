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
using BankingApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BankingApplicationInteractionForm
{
    public partial class CreateUserForm : Form
    {
        private readonly IBankUserService _bankUserService;
        private readonly IBankAccountService _bankAccountActions;
        public CreateUserForm(IBankUserService bankUserService, IBankAccountService bankAccountActions)
        {
            InitializeComponent();
            _bankUserService = bankUserService;
            _bankAccountActions = bankAccountActions;
        }
        private void CreateUserButton_Click(object sender, EventArgs e)
        {

            try
            {
                _bankUserService.CreateNewUser(EmailInputTextbox.Text, PasswordInputTextbox.Text);
                MessageBox.Show("User Created", "", MessageBoxButtons.OK);
                EmailInputTextbox.Text = "";
                PasswordInputTextbox.Text = "";
            }
            catch
            {
                MessageBox.Show("Invalid email address");
            }
        }

        private void BacktoLoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

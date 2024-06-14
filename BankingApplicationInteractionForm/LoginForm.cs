using BankingApplication;
using BankingApplication.Interfaces;
using BankingApplication.LogicClasses;
using BankingApplication.Models;
using Microsoft.Extensions.DependencyInjection;

namespace BankingApplicationInteractionForm
{
    public partial class LoginForm : Form
    {
        private readonly IBankUserService _bankUserService;
        private readonly IBankAccountService _bankAccountService;
        public LoginForm(IBankUserService bankUserService, IBankAccountService bankAccountActions)
        {
            InitializeComponent();
            _bankUserService = bankUserService;
            _bankAccountService = bankAccountActions;
        }

        private void CreateNewUserButton_Click(object sender, EventArgs e)
        {
            var createUserForm = new CreateUserForm(_bankUserService, _bankAccountService);
            createUserForm.ShowDialog();
        }

        private void CreateNewAccountButton_Click(object sender, EventArgs e)
        {
            var createAccountForm = new CreateAccountForm(_bankUserService, _bankAccountService);
            createAccountForm.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            var foundUser = _bankUserService.RetrieveUserByEmail(LoginEmailTextbox.Text);
            if (foundUser.Password == LoginPasswordTextbox.Text)
            {
                var loggedInUserForm = new LoggedInUserForm(_bankUserService, _bankAccountService);
                loggedInUserForm._userDetails = foundUser;
                loggedInUserForm.ShowDialog();
                LoginEmailTextbox.Clear();
                LoginPasswordTextbox.Clear();
            }
            else
            {
                MessageBox.Show("no user found with that email/password incorrect");
            }
        }
    }
}

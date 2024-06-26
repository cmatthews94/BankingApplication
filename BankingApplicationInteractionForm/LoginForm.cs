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
        private readonly ITransactionService _transactionService;
        private readonly IPasswordHashingService _passwordHashingService;
        public LoginForm(IBankUserService bankUserService, IBankAccountService bankAccountActions, ITransactionService transactionService, IPasswordHashingService bankAuthenticationService)
        {
            InitializeComponent();
            _bankUserService = bankUserService;
            _bankAccountService = bankAccountActions;
            _transactionService = transactionService;
            _passwordHashingService = bankAuthenticationService;

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
            var foundUser = _bankUserService.GetUserByEmail(LoginEmailTextbox.Text);
            var result = _passwordHashingService.VerifyLoginDetails(foundUser.Password, LoginPasswordTextbox.Text);
            if (!result)
            {
                MessageBox.Show("Password is incorrect");
                return;
            }
            else
            {
                var loggedInUserForm = new LoggedInUserForm(_bankUserService, _bankAccountService, _transactionService, _passwordHashingService);
                loggedInUserForm.userDetails = foundUser;
                loggedInUserForm.ShowDialog();
                LoginEmailTextbox.Clear();
                LoginPasswordTextbox.Clear();
            }
        }

        private void DeleteUsersButton_Click(object sender, EventArgs e)
        {
            _bankUserService.DeleteUserByUserId(1);
        }
    }
}

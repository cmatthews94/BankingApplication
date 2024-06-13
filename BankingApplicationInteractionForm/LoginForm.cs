using BankingApplication.Interfaces;
using BankingApplication.LogicClasses;
using Microsoft.Extensions.DependencyInjection;

namespace BankingApplicationInteractionForm
{
    public partial class LoginForm : Form
    {
        private readonly IBankUserService _bankUserService;
        private readonly IBankAccountService _bankAccountActions;
        public LoginForm(IBankUserService bankUserService, IBankAccountService bankAccountActions)
        {
            InitializeComponent();
            _bankUserService = bankUserService;
            _bankAccountActions = bankAccountActions;
        }

        private void CreateNewUserButton_Click(object sender, EventArgs e)
        {
            var createUserForm = new CreateUserForm(_bankUserService, _bankAccountActions);
            createUserForm.Show();
        }

        private void CreateNewAccountButton_Click(object sender, EventArgs e)
        {
            var createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
        }
    }
}

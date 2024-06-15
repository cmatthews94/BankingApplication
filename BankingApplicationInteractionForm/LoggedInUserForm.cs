using BankingApplication.Interfaces;
using BankingApplication.Models;
using Microsoft.Identity.Client.NativeInterop;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankingApplicationInteractionForm
{
    public partial class LoggedInUserForm : Form
    {
        private readonly IBankUserService _bankUserService;
        private readonly IBankAccountService _bankAccountService;
        private readonly ITransactionService _transactionService;

        public BankUser _userDetails;

        private List<Label> _labelGroup1 = new List<Label>();
        private List<Label> _labelGroup2 = new List<Label>();
        private List<Label> _labelGroup3 = new List<Label>();


        public LoggedInUserForm(IBankUserService bankUserService, IBankAccountService bankAccountService, ITransactionService transactionService)
        {
            InitializeComponent();
            _bankUserService = bankUserService;
            _bankAccountService = bankAccountService;
            _transactionService = transactionService;
        }
        private void LoggedInUserForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _userDetails.UserAccounts.Count; i++)
            {
                PickAccountCombobox.Items.Add(_userDetails.UserAccounts.ElementAt(i).AccountNumber.ToString());
            }
            TransactionTypeCombobox.Items.Add(TransactionType.Withdrawal);
            TransactionTypeCombobox.Items.Add(TransactionType.Deposit);
            TransactionAmountTextbox.Text = "0.00";
            TransactionTypeCombobox.Text = "---Select---";
            LoadFormData();
        }

        private void TransactionAmountTextbox_Validating(object sender, CancelEventArgs e)
        {
            var currencyCheckReg = new Regex(@"^[0-9]*(\.[0-9]{0,2})?$");
            if (currencyCheckReg.IsMatch(TransactionAmountTextbox.Text) == false)
            {
                TransactionAmountTextbox.Text = "0.00";
                MessageBox.Show("Please input a currency value (x.xx)");
            }
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransactionConfirmButton_Click(object sender, EventArgs e)
        {
            var account = _bankAccountService.GetAccountByAccountNumber(Convert.ToInt32(PickAccountCombobox.Text));
            var transactionAmount = Convert.ToDecimal(TransactionAmountTextbox.Text);
            if(TransactionTypeCombobox.Text == "Deposit")
            {
                _transactionService.CreateTransaction(TransactionType.Deposit, transactionAmount, account);
                MessageBox.Show($"Depositing {TransactionAmountTextbox.Text} into account #{account.AccountNumber}");
                TransactionAmountTextbox.Clear();
                LoadFormData();
            }
            else if(TransactionTypeCombobox.Text == "Withdrawal")
            {
                if(_transactionService.CheckIfTransactionViable(transactionAmount, account) == true)
                {
                    _transactionService.CreateTransaction(TransactionType.Withdrawal, transactionAmount, account);
                    MessageBox.Show($"Withdrawing {TransactionAmountTextbox.Text} from account #{account.AccountNumber}");
                    TransactionAmountTextbox.Clear();
                    LoadFormData();
                }
                else { MessageBox.Show($"Not enough funds in {account.AccountNumber}"); }
            }
            else { MessageBox.Show("Please choose a transaction type"); }
        }
        private void LoadFormData()
        {
            //decided on the labelgroups myself
            _labelGroup1.AddRange(new List<Label> {
                this.Account1NumberLabel,
                this.Account1NumberDisplayLabel,
                this.Account1BalanceDisplayLabel,
                this.Account1BalanceLabel
            });
            _labelGroup2.AddRange(new List<Label> {
                this.Account2NumberLabel,
                this.Account2NumberDisplayLabel,
                this.Account2BalanceDisplayLabel,
                this.Account2BalanceLabel
            });
            _labelGroup3.AddRange(new List<Label> {
               this.Account3NumberLabel,
               this.Account3NumberDisplayLabel,
               this.Account3BalanceDisplayLabel,
                this.Account3BalanceLabel
            });
            this.LoggedInUserEmailDisplayLabel.Text = _userDetails.EmailAddress;
            this.LoggedInUserIdDisplayLabel.Text = _userDetails.UserId.ToString();

            //used chatGPT to consolidate an absolutely monstrous switch case method
            var accountLabels = new List<List<Label>> { _labelGroup1, _labelGroup2, _labelGroup3 }; // Assuming _labelGroup3 exists for third account
            var accountNumberLabels = new List<Label> { Account1NumberDisplayLabel, Account2NumberDisplayLabel, Account3NumberDisplayLabel };
            var accountBalanceLabels = new List<Label> { Account1BalanceDisplayLabel, Account2BalanceDisplayLabel, Account3BalanceDisplayLabel };

            for(int i = 0; i < _userDetails.UserAccounts.Count; i++)
            {
                foreach(Label l in accountLabels[i])
                {
                    l.Show();
                }
                accountNumberLabels[i].Text = _userDetails.UserAccounts.ElementAt(i).AccountNumber.ToString();
                accountBalanceLabels[i].Text = _userDetails.UserAccounts.ElementAt(i).Balance.ToString();
            }
            TransactionAmountTextbox.Text = "0.00";
            TransactionTypeCombobox.Text = "---Select---";
        }
    }
}

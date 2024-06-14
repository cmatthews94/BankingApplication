using BankingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Interfaces
{
    public interface IBankAccountService
    {
        public void AddNewAccount(BankAccount newAccount);
        public BankAccount RetrieveAccountByAccountNumber(int accountNumber);
        public void UpdateAccountInfo(BankAccount account);
        public void DeleteAccountByAccountNumber(int accountNumber);
        public void CreateNewAccountForUserId(BankUser user);

    }
}

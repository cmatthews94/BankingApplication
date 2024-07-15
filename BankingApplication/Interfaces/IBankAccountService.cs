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
        public BankAccount CreateNewAccount(int ownerId);
        public BankAccount GetAccountByAccountNumber(int accountNumber);
        public void DeleteAccountByAccountNumber(int accountNumber);
        public void UpdateAccountBalance(Transaction transaction, BankAccount account);
    }
}

using BankingApplication.Interfaces;
using BankingApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.LogicClasses
{
    public class BankAccountService : IBankAccountService
    {
        private readonly BankingApplicationDbContext _context;
        public BankAccountService(BankingApplicationDbContext context)
        {
            _context = context;
        }
        //creates a new account attached to the user provided
        public BankAccount CreateNewAccount(int ownerId)
        {
            var newAccount = new BankAccount()
            {
                UserId = ownerId,
                Balance = 0,
            };
            return newAccount;
        }

        public BankAccount GetAccountByAccountNumber(int accountNumber)
        {
            if (_context.BankAccounts.FirstOrDefault(i => i.AccountNumber == accountNumber) != null)
            {
                return _context.BankAccounts.FirstOrDefault(i => i.AccountNumber == accountNumber);
            }
            else throw new Exception("account number not recognised");

        }
        public void DeleteAccountByAccountNumber(int accountNumber)
        {
            _context.BankAccounts.Where(i => i.AccountNumber == accountNumber).ExecuteDelete();
            _context.SaveChanges();
        }

        public void UpdateAccountBalance(Transaction transaction, BankAccount account)
        {
            if (transaction.TransactionType == TransactionType.Withdrawal)
            {
                account.Balance = (account.Balance - transaction.TransactionValue);
                _context.SaveChanges();
            }
            else if(transaction.TransactionType == TransactionType.Deposit)
            {
                account.Balance = account.Balance + transaction.TransactionValue;
                _context.SaveChanges();
            }
        }
    }
}

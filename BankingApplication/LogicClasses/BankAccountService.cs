using BankingApplication.Interfaces;
using BankingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.LogicClasses
{
    public class BankAccountService : IBankAccountService
    {
        // Dependency injection for AppDbContext
        private readonly BankingApplicationDbContext _context;
        public BankAccountService(BankingApplicationDbContext context)
        {
            _context = context;
        }
        public void AddNewAccount(BankAccount newAccount)
        {
            _context.BankAccounts.Add(newAccount);
            _context.SaveChanges();
        }
        public BankAccount RetrieveAccountByAccountNumber(int accountNumber)
        {
            if (_context.BankAccounts.FirstOrDefault(i => i.AccountNumber == accountNumber) != null)
            {
                return _context.BankAccounts.FirstOrDefault(i => i.AccountNumber == accountNumber);
            }
            else throw new Exception("account number not recognised");

        }
        public void UpdateAccountInfo(BankAccount account)
        {
            var existingAccountInfo = RetrieveAccountByAccountNumber(account.AccountNumber);

            //alters balance on the account
            existingAccountInfo.Balance = account.Balance;
            //alters who the account belongs to
            existingAccountInfo.BankUser = account.BankUser;

        }
        public void DeleteAccountByAccountNumber(int accountNumber)
        {
            _context.BankAccounts.Remove(RetrieveAccountByAccountNumber(accountNumber));
            _context.SaveChanges();
        }
        public void CreateNewAccountForUserId(BankUser user)
        {
            if(user.UserAccounts.Count() < 3)
            {
                var newAccount = new BankAccount()
                {
                    UserId = user.UserId,
                    Balance = 0.00m
                };

                user.UserAccounts.Add(newAccount);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("user has reached maximum number of accounts");
            }
        }
    }
}

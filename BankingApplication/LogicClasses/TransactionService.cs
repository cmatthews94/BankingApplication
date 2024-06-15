using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using BankingApplication.Interfaces;
using BankingApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BankingApplication.LogicClasses
{
    public class TransactionService : ITransactionService
    {
        private readonly BankingApplicationDbContext _context;
        private readonly IBankAccountService _accountService;
        public TransactionService(BankingApplicationDbContext context, IBankAccountService accountService)
        {
            _context = context;
            _accountService = accountService;
        }

        public void CreateTransaction(TransactionType transactionType, decimal transactionValue, BankAccount account)
        {
            var transaction = new Transaction
            {
                TransactionDate = DateTime.Now,
                TransactionType = transactionType,
                TransactionValue = transactionValue,
                BankAccount = account,
                AccountNumber = account.AccountNumber,
            };
            _accountService.UpdateAccountBalance(transaction, account);
            account.Transactions.Add(transaction); 
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }
        public void DeleteTransaction(int transactionId)
        {
            _context.Transactions.Where(c => c.TransactionId == transactionId).ExecuteDelete();
            _context.SaveChanges();
        }
        public Transaction GetTransactionById(int transactionId)
        {
            return _context.Transactions.First(t => t.TransactionId == transactionId);
        }
        public List<Transaction> FindTransactionsForAccountNumber(int accountNumber)
        {
            var account = _accountService.GetAccountByAccountNumber(accountNumber);

            return account.Transactions.ToList();
        }
        public bool CheckIfTransactionViable(decimal amount, BankAccount account)
        { 
            return ((account.Balance - amount) >= 0.00m);
        }
    }
}

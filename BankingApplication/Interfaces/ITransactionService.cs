using BankingApplication.Models;
using System.Transactions;
using Transaction = BankingApplication.Models.Transaction;

namespace BankingApplication.Interfaces
{
    public interface ITransactionService
    {
        //opting to exclude Update function for transactions as they will be auditable and should be uneditable
        public void CreateTransaction(TransactionType transactionType, decimal transactionValue, BankAccount account);
        public List<Transaction> FindTransactionsForAccountNumber(int accountNumber);
        public Transaction GetTransactionById(int transactionId);
        //delete function can remain for use during project creation
        public void DeleteTransaction(int transactionId);
        public bool CheckIfTransactionViable(decimal amount, BankAccount account);
    }
}
using BankingApplication;
using BankingApplication.Interfaces;
using BankingApplication.LogicClasses;
using BankingApplication.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplicationTests.TestClasses
{
    [TestFixture]
    public class TransactionTests
    {

        private BankingApplicationDbContext _context;
        private Mock<IBankUserService> _bankUserServiceMock;
        private IBankAccountService _bankAccountService;
        private ITransactionService _transactionService;

        [SetUp]
        public void Setup()
        {
            _bankUserServiceMock = new Mock<IBankUserService>();

            // Use in-memory database
            var options = new DbContextOptionsBuilder<BankingApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

            _context = new BankingApplicationDbContext(options);
            _bankAccountService = new BankAccountService(_context);
            _transactionService = new TransactionService(_context, _bankAccountService);

        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [Test]
        public void CreateTransaction_WithValidTransactionInfo_ShouldAddTransactionToDb()
        {
            //arrange
            TransactionType transactionType;
            var transactionValue = 10.00m;
            var account = _bankAccountService.CreateNewAccount(1);

            //act
            _transactionService.CreateTransaction(0, transactionValue, account);

            //assert
            var transactionsFound = _transactionService.FindTransactionsForAccountNumber(account.AccountNumber);
            Assert.That(transactionsFound, Is.Not.Null);
        }

        //redundant as above method already tests this
        [Test]
        public void FindTransactionsForAccountNumber_WithValidAccountNumber_ShouldReturnTransactions()
        {
            //arrange
            TransactionType transactionType;
            var transactionValue = 10.00m;
            var account = _bankAccountService.CreateNewAccount(1);
            _transactionService.CreateTransaction(0, transactionValue, account);
            //act
            var transactionsFound = _transactionService.FindTransactionsForAccountNumber(account.AccountNumber);

            //Assert
            Assert.That(transactionsFound, Is.Not.Null);
        }
        [Test]
        public void CheckIfTransactionViable_WithUnviableTransaction_ShouldReturnFalse()
        {
            //arrange
            var transactionAmount = 20.00m;
            var account = _bankAccountService.CreateNewAccount(1);

            //act
            var result = _transactionService.CheckIfTransactionViable(transactionAmount, account);

            //assert
            Assert.IsFalse(result);
        }
    }
}

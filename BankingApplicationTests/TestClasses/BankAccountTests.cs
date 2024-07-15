using BankingApplication.Interfaces;
using BankingApplication;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using BankingApplication.LogicClasses;
using BankingApplication.Models;
using System.Security.Cryptography.X509Certificates;

namespace BankingApplicationTests.TestClasses
{
    [TestFixture]
    public class BankAccountTests
    {
        private Mock<IPasswordHashingService> _passwordHashingServiceMock;
        private Mock<IBankUserService> _bankUserServiceMock;
        private IBankUserService _bankUserService;
        private BankingApplicationDbContext _context;
        private IBankAccountService _bankAccountService;

        [SetUp]
        public void Setup()
        {

            //initialize mocks
            _passwordHashingServiceMock = new Mock<IPasswordHashingService>();
            _bankUserServiceMock = new Mock<IBankUserService>();

            //use in memory database
            var options = new DbContextOptionsBuilder<BankingApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
            _context = new BankingApplicationDbContext(options);

            _bankAccountService = new BankAccountService(_context);
            _bankUserService = new BankUserService(_context, _bankAccountService, _passwordHashingServiceMock.Object);

        }
        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [Test]
        public void CreateNewAccount_WithCorrectParamType_ShouldReturnBankAccountObject()
        {
            //arrange
            var UserId = 1;

            //act
            var account = _bankAccountService.CreateNewAccount(UserId);

            //assert
            Assert.IsNotNull(account);
            Assert.AreEqual(account.GetType(), typeof(BankAccount));

        }

        [Test]
        public void GetAccountByAccountNumber_WithValidAccountNumber_ShouldReturnBankAccount()
        {
            //arrange
            var user = new BankUser()
            {
                UserId = 1,
                EmailAddress = "test@test.com",
                Password = "password"
            };

            var account = _bankAccountService.CreateNewAccount(user.UserId);
            _bankUserService.AddAccountToUser(user, account);
            _context.Add(user);
            _context.SaveChanges();

            //act
            var foundAccount = _bankAccountService.GetAccountByAccountNumber(user.UserId);

            //assert
            Assert.That(foundAccount, Is.Not.Null);
            Assert.That(account.AccountNumber == foundAccount.AccountNumber, Is.True);

        }

        [Test]
        public void GetAccountByAccountNumber_WithInvalidAccountNumber_ShouldThrowException()
        {
            //arrange
            var accountNumber = 10;

            //Act & Assert
            var ex = Assert.Throws<Exception>(() => _bankAccountService.GetAccountByAccountNumber(accountNumber));
            Assert.That(ex.Message, Is.EqualTo("account number not recognised"));

        }
    }
}

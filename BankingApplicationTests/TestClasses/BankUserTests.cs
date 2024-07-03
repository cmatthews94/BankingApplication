using BankingApplication.Interfaces;
using BankingApplication;
using Moq;
using BankingApplication.LogicClasses;
using BankingApplication.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace BankingApplicationTests.TestClasses
{
    [TestFixture]
    public class BankUserTests
    {
        private Mock<IPasswordHashingService> _passwordHashingServiceMock;
        private Mock<IBankAccountService> _bankAccountServiceMock;
        private BankingApplicationDbContext _context;
        private IBankUserService _bankUserService;

        [SetUp]
        public void Setup()
        {
            _passwordHashingServiceMock = new Mock<IPasswordHashingService>();
            _bankAccountServiceMock = new Mock<IBankAccountService>();

            var options = new DbContextOptionsBuilder<BankingApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new BankingApplicationDbContext(options);

            _bankUserService = new BankUserService(_context, _bankAccountServiceMock.Object, _passwordHashingServiceMock.Object);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        // Create New User Function Tests

        [Test]
        public void CreateNewUser_WithValidEmailAndPassword_ShouldCreateUser()
        {
            // Arrange
            var email = "test@example.com";
            var password = "password123";
            _passwordHashingServiceMock.Setup(x => x.VerifyIfEmailIsValid(email)).Returns(true);
            _passwordHashingServiceMock.Setup(x => x.HashPassword(password)).Returns("hashedPassword");

            // Act
            _bankUserService.CreateNewUser(email, password);

            // Assert
            _passwordHashingServiceMock.Verify(x => x.VerifyIfEmailIsValid(email), Times.Once);
            _passwordHashingServiceMock.Verify(x => x.HashPassword(password), Times.Once);
            _bankAccountServiceMock.Verify(x => x.CreateNewAccount(It.Is<BankUser>(u => u.EmailAddress == email && u.Password == "hashedPassword")), Times.Once);

            var user = _context.BankUsers.SingleOrDefault(u => u.EmailAddress == email);
            Assert.IsNotNull(user);
            Assert.AreEqual("hashedPassword", user.Password);
        }

        [Test]
        public void CreateNewUser_WithInvalidEmail_ShouldThrowException()
        {
            // Arrange
            var email = "invalidEmail";
            var password = "password123";
            _passwordHashingServiceMock.Setup(x => x.VerifyIfEmailIsValid(email)).Returns(false);

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _bankUserService.CreateNewUser(email, password));
            Assert.That(ex.Message, Is.EqualTo("e-mail provided is invalid"));
            _passwordHashingServiceMock.Verify(x => x.VerifyIfEmailIsValid(email), Times.Once);
            _passwordHashingServiceMock.Verify(x => x.HashPassword(It.IsAny<string>()), Times.Never);
            _bankAccountServiceMock.Verify(x => x.CreateNewAccount(It.IsAny<BankUser>()), Times.Never);

            Assert.AreEqual(0, _context.BankUsers.Count());
        }


    }
}
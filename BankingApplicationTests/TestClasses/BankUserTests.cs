using BankingApplication.Interfaces;
using BankingApplication;
using Moq;
using BankingApplication.LogicClasses;
using BankingApplication.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using BankingApplication.Migrations;
using System.Data.Entity;

namespace BankingApplicationTests.TestClasses
{
    [TestFixture]
    public class BankUserTests
    {
        private Mock<IPasswordHashingService> _passwordHashingServiceMock;
        private Mock<IBankAccountService> _bankAccountServiceMock;
        private Mock<IBankUserService> _bankUserServiceMock;
        private BankingApplicationDbContext _context;
        private IBankUserService _bankUserService;

        [SetUp]
        public void Setup()
        {
            // Initialize the mocks
            _passwordHashingServiceMock = new Mock<IPasswordHashingService>();
            _bankAccountServiceMock = new Mock<IBankAccountService>();
            _bankUserServiceMock = new Mock<IBankUserService>();    

            // Use in-memory database
            var options = new DbContextOptionsBuilder<BankingApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

            _context = new BankingApplicationDbContext(options);

            // Initialize the service with the context and mocks
            _bankUserService = new BankUserService(_context, _bankAccountServiceMock.Object, _passwordHashingServiceMock.Object);
        }
        [TearDown]
        public void TearDown()
        {
            // Clean up any resources or reset states here if necessary
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
            _passwordHashingServiceMock.Setup(x=>x.VerifyIfEmailIsValid(email)).Returns(false);

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _bankUserService.CreateNewUser(email, password));
            Assert.That(ex.Message, Is.EqualTo("e-mail provided is invalid"));
        }

        [Test]
        public void GetUserbyEmail_WithValidEmail_ShouldGetUser()
        {
            //Arrange
            var newEmail = "test@example.com";
            var newPassword = "password123";
            _passwordHashingServiceMock.Setup(x => x.VerifyIfEmailIsValid(newEmail)).Returns(true);
            _passwordHashingServiceMock.Setup(x => x.HashPassword(newPassword)).Returns("hashedPassword");
            _bankUserService.CreateNewUser(newEmail, newPassword);  

            //Act
            var user = _bankUserService.GetUserByEmail(newEmail);

            //Assert
            Assert.That(user.EmailAddress == newEmail);
        }

        [Test]
        public void GetUserByEmail_WithNonExistentEmail_ShouldReturnNoUserFoundError()
        {
            //arrange
            var incorrectEmail = "test2@example.com";

            //act & assert
            var ex = Assert.Throws<Exception>(() => _bankUserService.GetUserByEmail(incorrectEmail));
            Assert.That(ex.Message, Is.EqualTo("No registered User found with provided e-mail"));
        }

        [Test]
        public async Task GetUserByEmailAsync_WithValidEmail_ShouldReturnBankUser()
        {
            //arrange
            var newEmail = "test@example.com";
            var newPassword = "password123";
            _passwordHashingServiceMock.Setup(x => x.VerifyIfEmailIsValid(newEmail)).Returns(true);
            _passwordHashingServiceMock.Setup(x => x.HashPassword(newPassword)).Returns("hashedPassword");
            _bankUserService.CreateNewUser(newEmail, newPassword);

            //act
            var user = await _bankUserService.GetUserByEmailAsync(newEmail);

            //assert
            Assert.That(user.EmailAddress, Is.EqualTo(newEmail));
        }
        [Test]
        public async Task GetUserByEmailAsync_WithInvalidEmail_ShouldThrowException()
        {

            //arrange
            var incorrectEmail = "test2@example.com";

            //act & assert
            var ex = Assert.ThrowsAsync<Exception>(() => _bankUserService.GetUserByEmailAsync(incorrectEmail));
            Assert.That(ex.Message, Is.EqualTo("No registered User found with provided e-mail"));
        }

        [Test]
        public void ChangeUserPassword_WithIncorrectCurrentPassword_ShouldThrowException()
        {
            //arrange
            var newEmail = "test@example.com";
            var correctPassword = "password123";
            var incorrectPassword = "password1234";
            _passwordHashingServiceMock.Setup(x => x.VerifyIfEmailIsValid(newEmail)).Returns(true);
            _passwordHashingServiceMock.Setup(x => x.HashPassword(correctPassword)).Returns("hashedPassword");
            _bankUserService.CreateNewUser(newEmail, correctPassword);

            //act & assert
            var ex = Assert.Throws<Exception>(() => _bankUserService.ChangeUserPassword(newEmail, incorrectPassword, "testpassword"));
            Assert.That(ex.Message, Is.EqualTo("provided password does not match current"));

        }
    }
}



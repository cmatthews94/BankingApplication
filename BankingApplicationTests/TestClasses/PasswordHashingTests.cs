using BankingApplication.Interfaces;
using BankingApplication.LogicClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplicationTests.TestClasses
{
    [TestFixture]
    public class PasswordHashingTests
    {
        private IPasswordHashingService _passwordHashingService;
        [SetUp]
        public void Setup()
        {
            _passwordHashingService = new PasswordHashingService();
        
        }

        [Test]
        public void HashPassword_WithValidParam_ShouldReturnHashedString()
        {
            //arrange
            var passwordToHash = "passwordtest";

            //act
            var hashedPassword = _passwordHashingService.HashPassword(passwordToHash);

            //assert
            Assert.That(_passwordHashingService.VerifyPassword(hashedPassword, passwordToHash));
        }

        [Test]
        public void VerifyIfEmailIsValid_WithValidEmail_ShouldReturnTrue()
        {
            //arrange
            var email = "test@test.com";
            //act
            var result = _passwordHashingService.VerifyIfEmailIsValid(email);
            //assert
            Assert.IsTrue(result);
        }
        [Test]
        public void VerifyIfEmailIsValid_WithInvalidEmail_ShouldReturnFalse()
        {
            //arrange
            var email = "testtest.com";
            //act
            var result = _passwordHashingService.VerifyIfEmailIsValid(email);
            //assert
            Assert.IsFalse(result);
        }
    }
}

using BankingApplication.Interfaces;
using BankingApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.LogicClasses
{
    public class BankUserService : IBankUserService
    {
        private readonly BankingApplicationDbContext _context;
        private readonly IBankAccountService _accountService;
        private readonly IPasswordHashingService _passwordHashingService;
        public BankUserService(BankingApplicationDbContext context, IBankAccountService accountService, IPasswordHashingService authenticationService)
        {
            _context = context;
            _accountService = accountService;
            _passwordHashingService = authenticationService; 
        }

        public void CreateNewUser(string email, string password)
        {
            var result = _passwordHashingService.VerifyIfEmailIsValid(email);
            if (!result)
            {
                throw new Exception("e-mail provided is invalid");
            }
            var passwordHash = _passwordHashingService.HashPassword(password);

            var newUser = new BankUser()
            {
                EmailAddress = email,
                Password = passwordHash,
            };
            _context.BankUsers.Add(newUser);
            _context.SaveChanges();
        }

        public void AttachAccountToUser(string email, BankAccount account)
        {
            var result = GetUserByEmail(email);
            _context.BankUsers.Attach(result);
            result.UserAccounts.Add(account);
            _context.Entry(result).Property(x => x.UserAccounts).IsModified = true;
            _context.SaveChanges();

        }
        public BankUser GetUserByEmail(string email)
        {
            try
            {
                return _context.BankUsers
                .Include(a => a.UserAccounts)
                .First(i => i.EmailAddress == email);
            }
            catch
            {
                throw new Exception("No registered User found with provided e-mail");
            }
        }

        public async Task<BankUser> GetUserByEmailAsync(string email)
        {
            try
            {
                return await _context.BankUsers
                    .Include(a => a.UserAccounts)
                    .FirstAsync(i => i.EmailAddress == email);
            }
            catch
            {
                throw new Exception("No registered User found with provided e-mail");
            }
        }

        public void ChangeUserPassword(string email,string currentPassword, string newPassword)
        {
            var user = GetUserByEmail(email);
            if(!_passwordHashingService.VerifyPassword(_passwordHashingService.HashPassword(currentPassword), user.Password))
            {
                throw new Exception("provided password does not match current");
            }

            var hashedNewPassword = _passwordHashingService.HashPassword(newPassword);
            user.Password = hashedNewPassword;

            try
            {
                _context.BankUsers.Attach(user);
                _context.Entry(user).Property(x => x.Password).IsModified = true;
                _context.SaveChanges();
            }
            catch
            {
                throw new Exception("password change failure");
            }
        }

        public void DeleteUserByUserId(int userId)
        {
            _context.BankUsers
                .Where(b => b.UserId == userId)
                .ExecuteDelete();
        }
        public void AddAccountToUser(BankUser user, BankAccount account)
        {
            user.UserAccounts.Add(account);
            _context.SaveChanges();
        }
    }
}

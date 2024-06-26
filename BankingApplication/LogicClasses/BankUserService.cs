using BankingApplication.Interfaces;
using BankingApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            _accountService.CreateNewAccount(newUser);
            _context.BankUsers.Add(newUser);
            _context.SaveChanges();
        }
        public BankUser GetUserByEmail(string email)
        {
                return _context.BankUsers
                    .Include(a => a.UserAccounts)
                    .First(i => i.EmailAddress == email);
        }
        public async Task<BankUser> GetUserByEmailAsync(string email)
        {
            return await _context.BankUsers
                .Include(a => a.UserAccounts)
                .FirstAsync(i => i.EmailAddress == email);
        }

        public void ChangeUserPassword(string email, string newPassword)
        {
            var hashedPassword = _passwordHashingService.HashPassword(newPassword);
            
            _context.BankUsers
                .Where(b => b.EmailAddress == email)
                .ExecuteUpdate(u => u.SetProperty(b => b.Password, hashedPassword));
            _context.SaveChanges();
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

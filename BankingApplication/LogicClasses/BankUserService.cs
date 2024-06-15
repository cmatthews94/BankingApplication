using BankingApplication.Interfaces;
using BankingApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.LogicClasses
{
    public class BankUserService : IBankUserService
    {
        private readonly BankingApplicationDbContext _context;
        private readonly IBankAccountService _accountService;
        public BankUserService(BankingApplicationDbContext context, IBankAccountService accountService)
        {
            _context = context;
            _accountService = accountService;
        }

        public void CreateNewUser(string email, string password)
        {
            var newUser = new BankUser()
            {
                EmailAddress = email,
                Password = password,
            };
            _accountService.CreateNewAccount(newUser);
            _context.BankUsers.Add(newUser);
            _context.SaveChanges();
        }
        public BankUser GetUserById(int id)
        {
            return _context.BankUsers.First(i => i.UserId == id);
        }
        public BankUser GetUserByEmail(string email)
        {
            return _context.BankUsers
                .Include(a => a.UserAccounts)
                .First(i => i.EmailAddress == email);
        }

        public void UpdateUserEmailOrPassword(BankUser user)
        {
            var existingUser = GetUserById(user.UserId);

            existingUser.EmailAddress = user.EmailAddress;
            existingUser.Password = user.Password;
            _context.SaveChanges();
        }
        public void DeleteUserByUserId(int userId)
        {
            _context.BankUsers.Where(i => i.UserId == userId).ExecuteDelete();
            _context.SaveChanges();
        }
        public void AddAccountToUser(BankUser user, BankAccount account)
        {
            user.UserAccounts.Add(account);
            _context.SaveChanges();
        }
    }
}

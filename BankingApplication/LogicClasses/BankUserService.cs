using BankingApplication.Interfaces;
using BankingApplication.Models;
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
        public BankUserService(BankingApplicationDbContext context)
        {
            _context = context;
        }

        public void AddNewUser(BankUser newUser)
        {
            _context.BankUsers.Add(newUser);
            _context.SaveChanges();
        }
        public BankUser RetrieveUserById(int id)
        {
            if (_context.BankUsers.FirstOrDefault(i => i.UserId == id) != null)
            {

                return _context.BankUsers.FirstOrDefault(i => i.UserId == id);
            }
            else throw new Exception("User Id not found");
        }
        public void UpdateUserInfo(BankUser user)
        {
            var existingUser = RetrieveUserById(user.UserId);

            //alters basic info
            existingUser.EmailAddress = user.EmailAddress;
            existingUser.Password = user.Password;
            _context.SaveChanges();
        }
        public void DeleteUserByUserId(int userId)
        {
            _context.BankUsers.Remove(RetrieveUserById(userId));
            _context.SaveChanges();
        }
    }
}

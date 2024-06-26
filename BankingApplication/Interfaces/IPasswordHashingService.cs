using BankingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Interfaces
{
    public interface IPasswordHashingService
    {
        string HashPassword(string password);
        bool VerifyLoginDetails(string passwordHash, string inputPassword);
        public bool VerifyIfEmailIsValid(string email);
    }
}

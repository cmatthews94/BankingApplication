using BankingApplication.Models;

namespace BankingApplication.Interfaces
{
    public interface IBankUserService
    {
        public void CreateNewUser(string email, string password);
        public BankUser GetUserById(int id);
        public BankUser GetUserByEmail(string email);
        public void UpdateUserEmailOrPassword(BankUser user);
        public void DeleteUserByUserId(int userId);
        public void AddAccountToUser(BankUser user, BankAccount account);
    }
}
using BankingApplication.Models;

namespace BankingApplication.Interfaces
{
    public interface IBankUserService
    {
        public void AddNewUser(BankUser newUser);
        public BankUser RetrieveUserById(int id);
        public BankUser RetrieveUserByEmail(string email);
        public void UpdateUserInfo(BankUser user);
        public void DeleteUserByUserId(int userId);
        public void CreateUserAndAddToDb(string email, string password);
        public void AddAccountToUser(BankUser user, BankAccount account);
    }
}
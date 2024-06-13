using BankingApplication.Models;

namespace BankingApplication.Interfaces
{
    public interface IBankUserService
    {
        public void AddNewUser(BankUser newUser);
        public BankUser RetrieveUserById(int id);
        public void UpdateUserInfo(BankUser user);
        public void DeleteUserByUserId(int userId);

    }
}
using BankingApplication.Models;

namespace BankingApplication.Interfaces
{
    public interface IBankUserService
    {
        public void CreateNewUser(string email, string password);
        public BankUser GetUserByEmail(string email);
        public Task<BankUser> GetUserByEmailAsync(string email);
        public void ChangeUserPassword(string email, string currentPassword, string newPassword);
        public void DeleteUserByUserId(int userId);
        public void AddAccountToUser(BankUser user, BankAccount account);
    }
}
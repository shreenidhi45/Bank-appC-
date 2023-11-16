using FinalProject.Models;

namespace FinalProject.Service
{
    public interface IAccountService
    {
        public List<Account> GetAllAccounts();
        public Account GetAccountById(long accNo);
        void Add(Account account);
    }
}

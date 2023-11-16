using FinalProject.Models;

namespace FinalProject.Service
{
    public interface IUserService
    {
        public List<User> GetAll();
        public User GetById(long id);
        public User Update(User user);
        public User Add(User user);
        public bool Delete(long id);
        //public User GetByUsername(string username);
        // public User Authenticate(string username, string password);
        //public string GetRoleName(User user);
    }
}

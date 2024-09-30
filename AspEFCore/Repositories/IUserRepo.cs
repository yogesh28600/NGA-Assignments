using AspEFCore.Models;

namespace AspEFCore.Repositories
{
    public interface IUserRepo
    {
        public User GetUser(string username);
        public List<User> GetUsers();
        public bool AddUser(User user);
    }
}

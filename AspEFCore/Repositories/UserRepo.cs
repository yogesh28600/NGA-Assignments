using AspEFCore.Context;
using AspEFCore.Models;

namespace AspEFCore.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly UserDbContext _context;
        public UserRepo(UserDbContext context)
        {
            this._context = context;
        }
        public User GetUser(string username)
        {
            return _context.Users.FirstOrDefault(x=>x.username == username);
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }
        public bool AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }
    }
}

using api.Data;
using api.Interfaces;
using api.Models;

namespace api.Repositories
{
  public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;            
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.OrderBy(p => p.Id).ToList();
        }
    }
}
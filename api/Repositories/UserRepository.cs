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
        
        public User GetUser(int id)
        {
            return _context.Users.Where(p => p.Id == id).FirstOrDefault();
        }

        public User GetUser(string name)
        {
            return _context.Users.Where(p => p.Name == name).FirstOrDefault();
        }

        public bool UserExists(int id)
        {
            return _context.Users.Any(p => p.Id == id);
        }

        public User IncrementProgrammingXP(int id)
        {
            var user = _context.Users.Where(p => p.Id == id).FirstOrDefault();
            
            user.ProgrammingXP = (user.ProgrammingXP + 2);
            
            _context.SaveChanges();
            
            return user;
        }

        public User DecrementProgrammingXP(int id)
        {
            var user = _context.Users.Where(p => p.Id == id).FirstOrDefault();
            
            if(user.ProgrammingXP > 0)
                user.ProgrammingXP = (user.ProgrammingXP - 2);
            
            _context.SaveChanges();
            
            return user;
        }

        public User IncrementFitnessXP(int id)
        {
            var user = _context.Users.Where(p => p.Id == id).FirstOrDefault();

            user.FitnessXP = (user.FitnessXP + 2);

            _context.SaveChanges();

            return user;
        }

        public User DecrementFitnessXP(int id)
        {
            var user = _context.Users.Where(p => p.Id == id).FirstOrDefault();

            if(user.FitnessXP > 0)
                user.FitnessXP = (user.FitnessXP - 2);
            
            _context.SaveChanges();

            return user; 
        }

        public User IncrementHouseworkXP(int id)
        {
            throw new NotImplementedException();
        }

        public User DecrementHouseworkXP(int id)
        {
            throw new NotImplementedException();
        }

        public User IncrementReadingXP(int id)
        {
            throw new NotImplementedException();
        }

        public User DecrementReadingXP(int id)
        {
            throw new NotImplementedException();
        }
    }
}
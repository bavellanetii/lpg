using api.Data;
using api.Models;

namespace api
{
  public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

        public void SeedDataContext()
        {
            if(!dataContext.Users.Any())
            {
                var users = new List<User>()
                {
                    new User()
                    {
                        Name = "Brandon",
                        ProgrammingLevel = 1,
                        ProgrammingXP = 0,
                        FitnessLevel = 1,
                        FitnessXP = 0,
                        HouseworkLevel = 1,
                        HouseworkXP = 0,
                        ReadingLevel = 1,
                        ReadingXP = 0 
                    }
                };
                dataContext.Users.AddRange(users);
                dataContext.SaveChanges();
            }
        }
    }
}
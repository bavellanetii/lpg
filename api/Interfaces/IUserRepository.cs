using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User GetUser(int id);
        User GetUser(string name);
        User IncrementProgrammingXP(int id);
        User DecrementProgrammingXP(int id);
        User IncrementFitnessXP(int id);
        User DecrementFitnessXP(int id);
        User IncrementHouseworkXP(int id);
        User DecrementHouseworkXP(int id);
        User IncrementReadingXP(int id);
        User DecrementReadingXP(int id);
        bool UserExists(int id);
    }
}
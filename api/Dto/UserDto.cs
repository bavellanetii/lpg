using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dto
{
    public class UserDto
    {
        public string Name { get; set; }
        public int ProgrammingLevel { get; set; }
        public int ProgrammingXP { get; set; }
        public int FitnessLevel { get; set; }
        public int FitnessXP { get; set; }
        public int HouseworkLevel { get; set; }
        public int HouseworkXP { get; set; }
        public int ReadingLevel { get; set; }
        public int ReadingXP { get; set; }
    }
}
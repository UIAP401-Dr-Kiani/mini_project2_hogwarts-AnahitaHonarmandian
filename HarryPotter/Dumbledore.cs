using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class Dumbledore : AllowedPerson
    {
        
        public List<Dorms> DormList { get ; }

        public Dumbledore(List<Dorms> dormList):
             base("Albus", "Dumbledore", 1800,
            Enums.Gender.MALE, "Christopher",
            "Admin", "1", Enums.RaceBlood.PURE_BLOOD,
            0, Enums.Pet.OWL, true, Enums.Role.TEACHER)
        {
            DormList = dormList;
        }


        }


    
}

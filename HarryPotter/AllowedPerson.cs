using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
     class AllowedPerson : Human
    {
       
        
        //TODO- received letter and schedule

        public int RoomNumber{ get  ;}
        public Pet Pet { get ; }
        
        public Groups Group
        {
            get ;
        }
        public Boolean HasBaggage
        {
            get ;
        }
        public Role Role
        {
            get ;
        }

       public AllowedPerson(int roomNumber, Pet pet, Groups group, bool hasBaggage, Role role)
        {
            RoomNumber = roomNumber;
            Pet = pet;
            Group = group;
            HasBaggage = hasBaggage;
            Role = role;
        }

        public AllowedPerson() { }
    }
}

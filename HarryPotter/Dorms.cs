using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class Dorms
    {
       
        //TODO- room,bed,code type

        public Groups Groups { get ; }
        public int Floor { get ; }
        public int Room { get ; }
        public bool Gender { get ;  }
        public int Bed { get ; }

        public Dorms(Groups groups, int floor, int room, bool gender, int bed)
        {
            Groups = groups;
            Floor = floor;
            Room = room;
            Gender = gender;
            Bed = bed;
        }
    }
}

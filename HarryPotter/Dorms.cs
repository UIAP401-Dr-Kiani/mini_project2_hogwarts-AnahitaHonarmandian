using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
     class Dorms
    {
       
        public Groups Groups { get ; }
        public int Floor { get ; }
        public int Room { get ; }
        public Gender AllowedGender { get ;  }
        public int BedCount { get ; }

        //public static int Code { get; } //?????

        public Dorms(Groups groups, int floor, int room, Gender allowedGender, int bed)
        {
            Groups = groups;
            Floor = floor;
            Room = room;
            AllowedGender = allowedGender;
            BedCount = bed;
        }
    }
}

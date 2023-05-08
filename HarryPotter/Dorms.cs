using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class Dorms
    {
       
        public Group Groups { get ; }
        public int Floor { get ; }
        public int Room { get ; }
        public Gender AllowedGender { get ;  }
        public int BedCount { get ; }

        //public static int Code { get; } //?????

        public Dorms(Group groups, int floor, int room, Gender allowedGender, int bed)
        {
            Groups = groups;
            Floor = floor;
            Room = room;
            AllowedGender = allowedGender;
            BedCount = bed;
        }
    }
}

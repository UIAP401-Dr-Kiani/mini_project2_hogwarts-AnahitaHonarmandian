using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class Dorm : IFileWorker<Dorm>
    {
       
        public Group Groups { get ; }
        public int Floor { get ; }
        public int Room { get ; }
        public GenderType AllowedGender { get ;  }
        public int BedCount { get ; }

        public string FileName { get => "Dorm"; }
      
        



        //public static int Code { get; } //?????

        public Dorm(Group groups, int floor, int room, GenderType allowedGender, int bed)
        {
            Groups = groups;
            Floor = floor;
            Room = room;
            AllowedGender = allowedGender;
            BedCount = bed;
        }

        public List<Dorm> GetFromFile()
        {
            var dorms = new List<Dorm>();
            var list_temp = FileWorker.Read(FileName);

            foreach (List<string> dorm_info in list_temp)
            {

                var group = dorm_info[0];
                int floor = int.Parse(dorm_info[1]);
                int room = int.Parse(dorm_info[2]);
                Enum.TryParse(dorm_info[3], out GenderType gender);
                int bedCount= int.Parse(dorm_info[4]);

                dorms.Add(new Dorm(group,floor,room,gender,bedCount));
            }
            return dorms;
        }
        bool isEqual(Dorm dorm)
        {
            return dorm.Groups == this.Groups && dorm.Floor == this.Floor && dorm.Room == this.Room;
        }
        bool IsDuplicate()
        {
            foreach (var dorm in GetFromFile())
            {
                if (isEqual(dorm))
                    return true;
            }

            return false;
        }
        public void WriteToFile()
        {
            if (!IsDuplicate())
                FileWorker.Write(FileName, ReadyToWrite());
        }

        public string ReadyToWrite()
        {
            return $"{Groups}|{Floor}|{Room }|{AllowedGender}|{BedCount}";
        }

    }
}

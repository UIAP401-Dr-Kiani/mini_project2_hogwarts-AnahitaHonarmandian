using HarryPotter.FileHandler;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkHandler;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class Dorm 
    {

        public int ID { get; set; }
        public string GroupID { get; }
        public int Floor { get; }
        public int Room { get; }
        public int BedCount { get; }
        public string FileName { get => "Dorm"; }
        public GenderType AllowedGender { get; }


        public Dorm(string groupId, int floor, int room, GenderType allowedGender, int bed)
            : this(new Random().Next(), groupId, floor, room, allowedGender, bed)
        {
            GroupID = groupId;
            Floor = floor;
            Room = room;
            AllowedGender = allowedGender;
            BedCount = bed;
        }

        public Dorm(int id, string groupId, int floor, int room, GenderType allowedGender, int bed)
        {
            ID = id;
            GroupID = groupId;
            Floor = floor;
            Room = room;
            AllowedGender = allowedGender;
            BedCount = bed;
        }

        bool IsEqual(Dorm dorm)
        {
            return dorm.GroupID == this.GroupID && dorm.Floor == this.Floor && dorm.Room == this.Room;
        }
        bool IsDuplicate()
        {
            foreach (var dorm in FileReader.GetDorms())
            {
                if (IsEqual(dorm))
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
            return $"{ID}|{GroupID}|{Floor}|{Room}|{AllowedGender}|{BedCount}";
        }

    }
}

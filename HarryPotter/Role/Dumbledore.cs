using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class Dumbledore : AllowedPerson
    {
        
        public List<Dorm> DormList { get ; }

        public new string FileName { get => "Dumbledore.txt"; }

        public Dumbledore(List<Dorm> dormList):
             base("Albus", "Dumbledore", 1800,
            Enums.GenderType.MALE, "Christopher",
            "Admin", "1", Enums.RaceBlood.PURE_BLOOD,
            0, Enums.Pet.OWL, true, Enums.Role.TEACHER)
        {
            DormList = dormList;
        }

        //public List<Dumbledore> GetFromFile()
        //{
        //    var dumbledore = new List<Dumbledore>();
        //    var list_temp = FileWorker.Read(FileName);

        //    foreach (List<string> person_info in list_temp)
        //    {
        //        string firstName = person_info[0];
        //        string lastName = person_info[1];
        //        int birthyear = int.Parse(person_info[2]);
        //        Enum.TryParse(person_info[3], out GenderType gender);
        //        var fatherName = person_info[4];
        //        var username = person_info[5];
        //        var password = person_info[6];
        //        Enum.TryParse(person_info[7], out RaceBlood race);

        //        dumbledore.Add(new Dumbledore(firstName, lastName, birthyear, gender, fatherName, username, password, race));
        //    }
        //    return dumbledore;
        //}
       
        //public void WriteToFile()
        //{
            
        //        FileWorker.Write(FileName, ReadyToWrite());
        //}

        //public string ReadyToWrite()
        //{
        //    return $"{FirstName}|{LastName}|{BirthYear}|{Gender}|{FatherName}|{Username}|{Password}|{Race}";
        //}


    }


    
}

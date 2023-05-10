using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class Professor : AllowedPerson
    {
        public Group Groups { get; }
        public bool SimultaneousTeaching { get ; }

        public new string FileName { get => "Professor.txt"; }

        public Professor(string firstName, string lastName, int birthyear, GenderType gender, string fatherName,
           string username, string password, RaceBlood race,
           int roomNumber, Pet pet, bool hasBaggage, Role role,bool simultaneousTeaching,Group group) :

            base( firstName,  lastName, birthyear, gender, fatherName, username, password, race,
            roomNumber, pet, hasBaggage, role)
        { 
           SimultaneousTeaching = simultaneousTeaching;
            Groups = group;

        }
        public List<Professor> GetFromFile()
        {
            var Professor = new List<Professor>();
            var list_temp = FileWorker.Read(FileName);

            foreach (List<string> person_info in list_temp)
            {

                var firstName = person_info[0];
                var lastName = person_info[1];
                Enum.TryParse(person_info[2], out Group groups);
                var simultaneousTeaching = person_info[3];
               

                Professor.Add(new Professor(firstName,lastName, groups,simultaneousTeaching)); ;
            }
            return Professor;
        }
        bool isEqual(Professor professor)
        {
            return professor.FirstName==this.FirstName && professor.LastName==this.LastName && professor.Groups == this.Groups && professor.SimultaneousTeaching == this.SimultaneousTeaching;
        }
        bool IsDuplicate()
        {
            foreach (var professor in GetFromFile())
            {
                if (isEqual(professor))
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
            return $"{FirstName}|{LastName}|{Groups}|{SimultaneousTeaching}";
        }



    }
}

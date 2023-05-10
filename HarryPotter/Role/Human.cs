using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;



namespace HarryPotter
{
    public class Human : IFileWorker<Human>
    {
        
        public string FirstName { get; }
        
        public string LastName { get; }
      
        public string FullName { get { return FirstName + ' ' + LastName; } }
       
        public int BirthYear { get; }
       
        public GenderType Gender { get; }

        public string FatherName { get; }
      
        public string Username { get; }
        
        public string Password { get; }
       
        public RaceBlood Race { get; }

        public string FileName { get => "Human.txt"; }
     


        public Human(string firstName, string lastName, int birthyear, GenderType gender, string fatherName, string username, string password, RaceBlood race)
        {
            FirstName = string.IsNullOrEmpty(firstName) ? "No Name" : firstName;
            LastName = lastName;
            BirthYear = Math.Abs(birthyear);
            Gender = gender;
            FatherName = fatherName;
            Username = username;
            Password = password;
            Race = race;
        }

        public List<Human> GetFromFile()
        {
            var humans = new List<Human>();
            var list_temp = FileWorker.Read(FileName);

            foreach (List<string> person_info in list_temp)
            {
                string firstName = person_info[0];
                string lastName = person_info[1];
                int birthyear = int.Parse(person_info[2]);
                Enum.TryParse(person_info[3], out GenderType gender);
                var fatherName = person_info[4];
                var username = person_info[5];
                var password = person_info[6];
                Enum.TryParse(person_info[7], out RaceBlood race);

                humans.Add(new Human(firstName, lastName, birthyear, gender, fatherName, username, password, race));
            }
            return humans;
        }
        bool isEqual(Human human)
        {
            return human.FirstName == this.FirstName && human.LastName == this.LastName && human.FatherName == this.FatherName;
        }
        bool IsDuplicate()
        {
            foreach (var human in GetFromFile())
            {
                if (isEqual(human))
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
            return $"{FirstName}|{LastName}|{BirthYear}|{Gender}|{FatherName}|{Username}|{Password}|{Race}";
        }

    }
}

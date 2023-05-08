using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;


namespace HarryPotter
{
    public class Human
    {
        
        public string FirstName { get; }
        
        public string LastName { get; }
      
        public string FullName { get { return FirstName + ' ' + LastName; } }
       
        public int BirthYear { get; }
       
        public bool Gender { get; }

        public string FatherName { get; }
      
        public string Username { get; }
        
        public string Password { get; }
       
        public RaceBlood Race { get; }
     

        public Human()
        {
            FirstName = "";
            LastName = "";
            BirthYear = 0;
            Gender = true;
            //Father = new Person();
            Username = "Admin";
            Password = "1";
        }

        public Human(string firstName, string lastName, int birthyear, Gender gender, string fatherName, string username, string password, RaceBlood race)
        {
            FirstName = string.IsNullOrEmpty(firstName) ? "No Name" : firstName;
            LastName = lastName;
            BirthYear = Math.Abs(birthyear);
            Gender = gender == Enums.Gender.FEMALE ? false : true;
            FatherName = fatherName;
            Username = username;
            Password = password;
            Race = race;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;


namespace HarryPotter
{
    abstract class Human
    {
        private string _firstName;
        private string _lastName;
        private uint _BirthYear;
        private Boolean _gender;
        private Human _Father;
        private readonly string _username;
        private string password;
        private RaceBlood race;

        public string FirstName
        {
            get;
        }
        public string LastName
        {
            get ;
        }

        public string FullName { get { return FirstName + ' ' + LastName; } }
        public int BirthYear
        {
            get ;
        }
        public Boolean Gender
        {
            get ;
        }
        public Human Father
        {
            get ;
        }
        public string Username
        {
            get ;
        }
        public string Password
        {
            get ;
        }
        public RaceBlood Race
        {
            get ;
        }

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

        public Human(string firstName, string lastName, int birthyear, bool gender, Human father, string username, string password, RaceBlood race)
        {
            FirstName = string.IsNullOrEmpty(firstName) ? "No Name" : firstName;

            LastName = lastName;
            BirthYear = Math.Abs(birthyear);

            Gender = gender;
            Father = father;
            Username = username;
            Password = password;
            Race = race;
        }

    }
}

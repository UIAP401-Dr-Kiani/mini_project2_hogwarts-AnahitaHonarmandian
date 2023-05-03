using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    class Human
    {
        private string _firstName;
        private string _lastName;
        private uint _BirthYear;
        private Boolean _sex;
        private Human _Father;
        private readonly string _username;
        private string password;
        private RaceBlood race;

        public string FirstName
        {
            get { return _firstName; }
        }
        public string LastName
        {
            get { return _lastName; }
        }
        public uint BirthYear
        {
            get { return _BirthYear; }
        }
        public Boolean Sex
        {
            get { return _sex; }
        }
        public Human Father
        {
            get { return _Father; }
        }
        public string Username
        {
            get { return _username; }
        }
        public string Password
        {
            get { return password; }
        }
        public RaceBlood Race
        {
            get { return race; }
        }
    }
}

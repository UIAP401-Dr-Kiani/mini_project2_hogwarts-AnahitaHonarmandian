using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
     class Professor : AllowedPerson
    {
        public Group Groups { get; }
        public bool SimultaneousTeaching { get ; }

        public Professor(string firstName, string lastName, int birthyear, Gender gender, string fatherName,
           string username, string password, RaceBlood race,
           int roomNumber, Pet pet, bool hasBaggage, Role role,bool simultaneousTeaching,Group group) :

            base( firstName,  lastName, birthyear, gender, fatherName, username, password, race,
            roomNumber, pet, hasBaggage, role)
        { 
           SimultaneousTeaching = simultaneousTeaching;
            Groups = group;

        }
    }
}

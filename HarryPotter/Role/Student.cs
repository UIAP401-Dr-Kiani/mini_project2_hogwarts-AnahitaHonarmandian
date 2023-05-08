using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class Student : AllowedPerson
    {

        public int PassedUnitCourses { get; }
        public int Semester { get; }
        public Group Group { get; }
        public int DormNumber { get; }


        public Student(
            string firstName, string lastName, int birthyear, Gender gender, string father, string username,
            string password, RaceBlood race, int roomNumber, Pet pet, Group group, bool hasBaggage, Role role,
            int passedCourses, int semester, int dormNumber) :

            base(firstName, lastName, birthyear, gender, father,
                username, password, race, roomNumber, pet, hasBaggage, role)
        {
            Group = group;
            PassedUnitCourses = passedCourses;
            Semester = semester;
            DormNumber = dormNumber;
        }
    }
}

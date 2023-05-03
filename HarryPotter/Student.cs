using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
     class Student : AllowedPerson
    {
        //private int _passedCourses;
        //private int _semester;
        //private int _dormNumber;

        public int PassedCourses { get; }
        public int Semester { get ; }

        public int DormNumber { get; }

        public Student(int passedCourses, int semester, int dormNumber) { 
            PassedCourses = passedCourses;
            Semester = semester;
            DormNumber = dormNumber;
        }
    }
}

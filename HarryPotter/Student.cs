using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class Student : AllowedPerson
    {
        private int _passedCourses;
        private int _semester;
        private int _dormNumber;

        public int PassedCourses { get { return _passedCourses; }}
        public int Semester { get { return _semester; } }

        public int DormNumber { get { return _dormNumber; }}
        
    }
}

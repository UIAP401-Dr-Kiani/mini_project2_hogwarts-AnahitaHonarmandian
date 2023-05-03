using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class Subjects
    {
        //TODO-time
        private int _numberOfStudents;
        private int _capacity;
        private uint _semesterPresentation;
        private string _name;

        public int numberOfStudents { get { return _numberOfStudents; } }
        public int capacity { get { return _capacity; } }
        public uint semesterPresentation { get {  return _semesterPresentation; } }
        public string name { get { return _name; } }
    }
}

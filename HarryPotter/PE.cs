using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class PE : Subjects
        //Physical Education
    {
        public string PeType { get ; }

        public PE(string peType) 
        {
            PeType = peType;
        }
    }
}

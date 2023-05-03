using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class PE : Subjects
    {
       
        public string PeType { get ; }

        public PE(string PeType) {
            this.PeType = PeType;
        }
    }
}

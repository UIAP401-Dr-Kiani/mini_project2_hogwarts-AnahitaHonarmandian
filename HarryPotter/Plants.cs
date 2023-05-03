using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class Plants : Subjects
    {
       

        public string Name { get ; }    
        public int Count { get ; }

        public Plants(string name, int count)
        {
            Name = name;
            Count = count;
        }
    }
}

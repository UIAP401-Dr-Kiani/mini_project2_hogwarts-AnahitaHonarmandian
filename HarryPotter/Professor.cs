using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class Professor : AllowedPerson
    {
        
        public bool SimultaneousTeaching { get ; }

        public Professor(bool simultaneousTeaching) 
        { 
           SimultaneousTeaching = simultaneousTeaching;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class Professor : AllowedPerson
    {
        private Boolean _simultaneousTeaching;

        public Boolean SimultaneousTeaching { get { return _simultaneousTeaching;} }
    }
}

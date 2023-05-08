using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class MagicHistory : Subjects
    {
       
        //TODO-CHARMS

        public List<Spell> Spells { get ; }

        public MagicHistory(List<Spell> spells)
        {
            Spells = spells;
        }
    }
}

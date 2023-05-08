using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class MagicHistory : Subjects
    {
       
        public List<Spell> Spells { get ; }

        public MagicHistory(string name, int capacity, uint semesterPresentation, uint minutesDuration):
            base( name,  capacity,  semesterPresentation,  minutesDuration)
        {
            Spells=new List<Spell>();   
        }
    }
}

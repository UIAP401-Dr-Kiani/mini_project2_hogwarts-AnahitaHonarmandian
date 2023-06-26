using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class Enums
    {
        public enum GenderType
        {
            MALE,
            FEMALE
        }
        public enum RaceBlood
        {
            HALF_BLOOD,
            PURE_BLOOD,
            MUGGLE_BLOOD
        }
       
        public enum Pet {
            CAT,
            RAT,
            OWL
        }
        
        public enum Role {
            TEACHER,
            STUDENT
        }
        
        public enum Types {
            HUFFLEPUFF,
            GRYFFINDOR,
            RAVENCLAW,
            SLYTHERIN
        }

        public enum SpellTypes
        {
            CHARM,
            CURSE,
            TRANSFIGURATION,
            HEALING,
            JINX,
            HEX,
            COUNTER_SPELLS
        }


    }
}

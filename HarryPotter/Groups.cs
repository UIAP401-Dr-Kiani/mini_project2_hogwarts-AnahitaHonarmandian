using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class Groups
    {
        private Enums _type;
        private int _score;
        //group members list
        //quidditch members list

        public int Score
        {
            get { return _score; }
        }
        public Enums Type { get { return _type; } }
    }
}

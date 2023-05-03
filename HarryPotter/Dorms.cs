using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class Dorms
    {
        private Groups _groups;
        private int _floor;
        private int _room;
        private int _bed;
        private Boolean _gender;
        //TODO- room,bed,code type

        public Groups Groups { get { return _groups; } }
        public int Floor { get { return _floor; } }
        public int Room { get { return _room; } }
        public bool Gender { get { return _gender; } }
        public int Bed { get { return _bed; } }

    }
}

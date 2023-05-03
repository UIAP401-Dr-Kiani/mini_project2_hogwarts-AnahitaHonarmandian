using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
     class AllowedPerson : Human
    {
        private int _roomNumber;
        
        private Pet _pet;
        private Groups _group;
        private Boolean _hasBaggage;
        private Role _role;
        //TODO- received letter and schedule

        public int RoomNumber
        {
            get { return _roomNumber; }
        }
        public Pet Pet
        {
            get { return _pet; }
        }
        public Groups Group
        {
            get { return _group; }
        }
        public Boolean HasBaggage
        {
            get { return _hasBaggage; }
        }
        public Role Role
        {
            get { return _role; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
     class AllowedPerson : Human
    {
        private int _roomNumber;
        //schedule
        private Enums _pet;
        private Groups _group;
        private Boolean _hasBaggage;
        private Enums _role;
        //recieved letter

        public int RoomNumber
        {
            get { return _roomNumber; }
        }
        public Enums Pet
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
        public Enums Role
        {
            get { return _role; }
        }
    }
}

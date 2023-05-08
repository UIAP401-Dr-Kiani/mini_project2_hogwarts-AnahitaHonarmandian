using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
     class Groups
    {
      
        public List<Student> Students { get; }
        public List<Professor> Professors { get; }
        public List<Student> QuidditchPlayers { get; }
        public int Score{ get ;  }
        public Types Type { get ; }

       public Groups(int score,Types type)
        {
            Students = new List<Student>();
            Professors = new List<Professor>(); 
            QuidditchPlayers = new List<Student>();
            Score = score;
            Type = type;
        }
    }
}

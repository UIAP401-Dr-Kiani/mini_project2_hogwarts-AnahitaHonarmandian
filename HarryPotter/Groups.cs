﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
     class Groups
    {
        //private Types _type;
        //private int _score;

        //TODO-group members list
        //quidditch members list

        public int Score{ get ;  }
        public Types Type { get ; }

       public Groups(int score,Types type)
        {
            Score = score;
            Type = type;
        }
    }
}

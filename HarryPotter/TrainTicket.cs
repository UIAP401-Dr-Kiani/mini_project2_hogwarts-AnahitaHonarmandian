﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class TrainTicket
    {
        public DateTime MoveDatetime { get; set; }
        //public DateTime MoveTime { get; set; }

        public string Src { get; set; }
        public string Destination { get; set; }

        public TrainTicket(string src, string destination,DateTime moveDatetime/*,DateTime moveTime*/)
        {
            this.Src = src;
            this.Destination = destination;
            this.MoveDatetime = moveDatetime;
            //this.MoveTime = moveTime;
        }
        
    }
}

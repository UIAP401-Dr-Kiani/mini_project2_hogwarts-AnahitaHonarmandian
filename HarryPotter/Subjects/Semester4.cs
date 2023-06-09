﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Subjects
{
    internal class Semester4 : Herbology
    {
        public Semester4(int capacity, uint semesterPresentation, uint minutesDuration, int professorID) :
           base("Semester3", capacity, semesterPresentation, 250, professorID)
        {

        }

        public override List<Plants> PlantsList()
        {
            var plants = new List<Plants>();
            plants.Add(new Plants("Alpha", 3));
            plants.Add(new Plants("Beta", 4));
            plants.Add(new Plants("Omega", 10));

            return plants;
        }
    }
}

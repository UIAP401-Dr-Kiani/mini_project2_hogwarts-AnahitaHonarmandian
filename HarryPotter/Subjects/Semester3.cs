using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Semester3 : Herbology
    {

        public Semester3(int capacity, uint semesterPresentation, uint minutesDuration, int professorID) :
           base("Semester3", capacity, semesterPresentation, 200, professorID)
        {

        }

        public override List<Plants> PlantsList()
        {
            var plants = new List<Plants>();
            plants.Add(new Plants("Mimbletonia", 3));
            plants.Add(new Plants("Flutterby", 4));
            plants.Add(new Plants("Leaping", 10));

            return plants;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Semester2 : Herbology
    {

        public Semester2(int capacity, uint semesterPresentation, uint minutesDuration, int professorID) :
          base("Semester3", capacity, semesterPresentation, 150, professorID)
        {

        }

        public override List<Plants> PlantsList()
        {
            var plants = new List<Plants>();
            plants.Add(new Plants("Shrivelfig", 15));
            plants.Add(new Plants("Chamomile", 14));
            plants.Add(new Plants("Asphodels", 11));

            return plants;
        }
    }
}

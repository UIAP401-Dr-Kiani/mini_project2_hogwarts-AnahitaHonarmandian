using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Semester1 : Herbology
    {

        public Semester1(int capacity, uint semesterPresentation) :
            base("Semester1", capacity, semesterPresentation, 100)
        {
        }
        public override List<Plants> PlantsList()
        {
            var plants = new List<Plants>();
            plants.Add(new Plants("Mandrake", 5));
            plants.Add(new Plants("Wolfsbane", 4));
            plants.Add(new Plants("Devil's snare", 1));
            plants.Add(new Plants("Wormwood", 5));

            return plants;
        }
    }
}

using System.Collections.Generic;

namespace HarryPotter
{
    public class Chemistry : Subject
    {
        public List<Chemicals> Chemicals { get; }

        public Chemistry(string name, int capacity, uint semesterPresentation, uint minutesDuration, int professorID)
            : base(name, capacity, semesterPresentation, minutesDuration, professorID)
        {
            Chemicals = new List<Chemicals>();
        }
    }
}

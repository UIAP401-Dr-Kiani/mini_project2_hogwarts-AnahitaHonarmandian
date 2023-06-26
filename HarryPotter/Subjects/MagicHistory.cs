using System.Collections.Generic;

namespace HarryPotter
{
    public class MagicHistory : Subject
    {
        public List<Spell> Spells { get; }
        public MagicHistory(string name, int capacity, uint semesterPresentation, uint minutesDuration, int professorID)
            : base(name, capacity, semesterPresentation, minutesDuration, professorID)
        {
            Spells = new List<Spell>();
        }

        public void AddNewMagic(Spell newMagic)
        {
            Spells.Add(newMagic);
        }
    }
}

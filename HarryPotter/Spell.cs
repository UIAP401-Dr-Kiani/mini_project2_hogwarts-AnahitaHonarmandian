using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Spell
    {
        public string Name { get; private set; }
        public string Content { get; private set; }
        public SpellTypes SpellType { get; private set; }

        Spell(string name, string content, SpellTypes spellType)
        {
            Name = name;
            Content = content;
            SpellType = spellType;
        }

    }
}

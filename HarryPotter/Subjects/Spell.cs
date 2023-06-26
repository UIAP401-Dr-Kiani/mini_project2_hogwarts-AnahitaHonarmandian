using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkHandler;
using static HarryPotter.Enums;


namespace HarryPotter
{
    public class Spell : IFileWorker
    {
        public string Name { get; private set; }
        public string Content { get; private set; }
        public SpellTypes SpellType { get; private set; }
        public string FileName { get => "Spell.txt"; }

        Spell(string name, string content, SpellTypes spellType)
        {
            Name = name;
            Content = content;
            SpellType = spellType;
        }

        public List<Spell> GetFromFile()
        {
            var spell = new List<Spell>();
            var list_temp = FileWorker.Read(FileName);

            foreach (List<string> spell_info in list_temp)
            {
                string name = spell_info[0];
                string content = spell_info[1];
                Enum.TryParse(spell_info[2], out SpellTypes spellType);


                spell.Add(new Spell(name, content, spellType));
            }
            return spell;
        }
        bool isEqual(Spell spell)
        {
            return spell.Name == this.Name && spell.Content == this.Content && spell.SpellType == this.SpellType;
        }
        bool IsDuplicate()
        {
            foreach (var spell in GetFromFile())
            {
                if (isEqual(spell))
                    return true;
            }

            return false;
        }
        public void WriteToFile()
        {
            if (!IsDuplicate())
                FileWorker.Write(FileName, ConvertToStringFile());
        }

        public string ConvertToStringFile()
        {
            return $"{Name}|{Content}|{SpellType}";
        }

        public override string ToString()
        {
            return $"Name:{Name}-Content:{Content}-Spell Type:{SpellType}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HarryPotter.Enums;

namespace HarryPotter
{
    public class Chemicals : IFileWorker<Chemicals>
    {
        public string Name { get; }
         public string Formula { get; }
        public string FileName { get => "Chemistry.txt"; }

        public Chemicals(string name,string formula) {
            Name = name;
            Formula = formula;
        }
        public override string ToString()
        {
            return Name + Formula;
        }


        public List<Chemicals> GetFromFile()
        {
            var chemicals = new List<Chemicals>();
            var list_temp = FileWorker.Read(FileName);

            foreach (List<string> chem_info in list_temp)
            {
                string name = chem_info[0];
                string formula = chem_info[1];
               

                chemicals.Add(new Chemicals(name, formula));
            }
            return chemicals;
        }
        bool isEqual(Chemicals chemicals)
        {
            return chemicals.Name == this.Name && chemicals.Formula == this.Formula;
        }
        bool IsDuplicate()
        {
            foreach (var chemicals in GetFromFile())
            {
                if (isEqual(chemicals))
                    return true;
            }

            return false;
        }
        public void WriteToFile()
        {
            if (!IsDuplicate())
                FileWorker.Write(FileName, ReadyToWrite());
        }

        public string ReadyToWrite()
        {
            return $"{Name}|{Formula}";
        }

    }
}

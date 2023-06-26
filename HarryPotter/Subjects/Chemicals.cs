using HarryPotter.FileHandler;
using System.Collections.Generic;
using WorkHandler;

namespace HarryPotter
{
    public class Chemicals : IFileWorker
    {
        public string Name { get; }
        public string Formula { get; }
        public string FileName { get => "Chemistry.txt"; }

        public Chemicals(string name, string formula)
        {
            Name = name;
            Formula = formula;
        }
        public override string ToString()
        {
            return Name + Formula;
        }


        bool isEqual(Chemicals chemicals)
        {
            return chemicals.Name == this.Name && chemicals.Formula == this.Formula;
        }
        bool IsDuplicate()
        {
            foreach (var chemicals in FileReader.GetChemicals())
            {
                if (isEqual(chemicals))
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
            return $"{Name}|{Formula}";
        }

    }
}

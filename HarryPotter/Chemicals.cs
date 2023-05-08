using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Chemicals
    {
        public string Name { get; }
         public string Formula { get; }

        public Chemicals(string name,string formula) {
            Name = name;
            Formula = formula;
        }
    }
}

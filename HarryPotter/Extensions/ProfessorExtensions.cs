using HarryPotter.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Extensions
{
    public static class ProfessorExtensions
    {
        public static AllowedPerson GetAllowedPerson(this Professor professor)
        {
            return Tables.AllowedPersons.FirstOrDefault(p => p.AllowedPersonID == professor.AllowedPersonID);
        }
    }
}

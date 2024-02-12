using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartasCode
{
    internal class TownsDB
    {
        public Town GetTown(int postCode)
        {
            return Towns.First();
        }

        private IList<Town> Towns = new List<Town>()
        {
            new Town(){Name = "Ostrava", PostCode = 70800},
            new Town(){Name = "Opava", PostCode = 74601},
            new Town(){Name = "Brno", PostCode = 89011}
        };
    }
}

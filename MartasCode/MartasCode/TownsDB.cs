using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartasCode
{
    internal class TownsDB 
    {
     //přidat metodu kterou budeme přidávat do seznamu AddTown
     //+ metodu, kterou budeme mazat
     //pridat metody ktera bude vyhledavat podle nazvu mesta (i jenom jeho casti)
     
        public Town? GetTownByPostCode(int postCode)
        {
            return Towns?.Where(town => town.PostCode == postCode).SingleOrDefault();
            //return Towns.SingleOrDefault(town => town.PostCode == postCode);
            //return Towns.FirstOrDefault(town => town.PostCode == postCode);


            foreach (var town in Towns)
            {
                if (town.PostCode == postCode)
                {
                    return town;
                }
            }
            return null;
        }

        public Town GetTownByPostCode2(int postCode)
        {
            return Towns.Single(town => town.PostCode == postCode); //ověření, že v seznamu je jen jedno město s daným PSČ
            /*var town = Towns.SingleOrDefault(town => town.PostCode == postCode);
            if (town == null)
            {
                throw new Exception("Town not found");
            }
            return town;*/
        }



        private IList<Town> Towns = new List<Town>()
        {
            new Town(){Name = "Ostrava", PostCode = 70800},
            new Town(){Name = "Ostravice", PostCode = 72569},
            new Town(){Name = "Opava", PostCode = 74601},
            new Town(){Name = "Brno", PostCode = 89011}
        };
    }
}

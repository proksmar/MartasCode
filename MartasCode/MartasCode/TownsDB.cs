using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartasCode
{
    internal class TownsDB 
    {
        private List<Town> _towns = new List<Town>()
        {
            new Town(){Name = "Ostrava", PostCode = 70800},
            new Town(){Name = "Ostravice", PostCode = 72569},
            new Town(){Name = "Opava", PostCode = 74601},
            new Town(){Name = "Brno", PostCode = 89011}
        };


        //1. přidat metodu kterou budeme přidávat do seznamu AddTown
        //2. metodu, kterou budeme mazat
        //3. pridat metody ktera bude vyhledavat podle nazvu mesta (i jenom jeho casti)

        public Town? GetTownByPostCode(int postCode)
        {
            return _towns?.Where(town => town.PostCode == postCode).SingleOrDefault();
            //return Towns.SingleOrDefault(town => town.PostCode == postCode);
            //return Towns.FirstOrDefault(town => town.PostCode == postCode);


            foreach (var town in _towns)
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
            return _towns.Single(town => town.PostCode == postCode); //ověření, že v seznamu je jen jedno město s daným PSČ
            /*var town = Towns.SingleOrDefault(town => town.PostCode == postCode);
            if (town == null)
            {
                throw new Exception("Town not found");
            }
            return town;*/
        }

        //1.
        public void AddTown(string name, int postcode)
        {
            _towns.Add(new Town() {Name = name, PostCode = postcode});
        }

        //2.
        public void RemoveTown(int postcode)
        {
            //pouzij _towns.RemoveAll(...)



            //if (town.PostCode == town.PostCode)
            {
                //_towns.Remove(town);
            }
        }

        //3.
        public IList<Town> SearchTown(string name)
        {
            //pouzij Where



            //if (town.Name.Contains("*M*"))
            //{
            //    return town;
            //}

            return new List<Town>();
        }

        internal IList<Town> GetAll()
        {
            return _towns;
        }
    }
}
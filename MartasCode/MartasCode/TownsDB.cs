using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            _towns.Add(new Town() { Name = name, PostCode = postcode });
        }

        //2. according postecode
        public void RemoveTown(int postcode, Town town)
        {
            //pouzij _towns.RemoveAll(...)


            if (postcode == town.PostCode)
            {
                _towns.Remove(town);
            }
            else { Console.WriteLine("Máš to blbě"); }
        }

        public void RemoveAll()
        {
            //not possible use foreach fot remove items
            while (_towns.Count > 0)
            {
                _towns.RemoveAt(0);
            }
        }

        public void AssertIsEmpty()
        {
            //remove before Assert
            if (_towns.Count > 0)
            {
                throw new InvalidOperationException("List of towns is not empty");
            }
        }

        //3.
        public IList<Town> SearchTown(string x)
        {
            var my = _towns.FindAll(town => town.Name.Contains(x)).ToList();

            return my;
        }

        internal IList<Town> GetAll()
        {
            return _towns;
        }
    }
}
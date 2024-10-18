// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using MartasCode;


var townsDb = new TownsDB();





Console.WriteLine("\r\nHledani podle postcode");
var back = townsDb.GetTownByPostCode(89011);
Console.WriteLine(back.Name);


Console.WriteLine("\r\nHledani podle jmena");
var result = townsDb.SearchTown("s");

foreach (var town in result)
{
    Console.WriteLine(town.Name);
}

Console.WriteLine("\r\nPridani");
townsDb.AddTown("Praha", 10000);
foreach (var town in townsDb.GetAll())
{
    Console.WriteLine(town.Name);
}


//Console.WriteLine("\r\nOdebrani");
//townsDb.RemoveTown(70800);


Console.WriteLine("\r\nStav na konci");
var s2 = townsDb.GetAll();
foreach (var town in s2)
{
    Console.WriteLine(town.Name);
}

Console.WriteLine("\r\nStav po RemoveAll - smazání bylo úspěšné, město lehlo popelem");
townsDb.RemoveAll();
Console.WriteLine();

Console.WriteLine("\r\nKontrola metody AssertCountOfTownsDB"); 
townsDb.AssertIsEmpty();
Console.WriteLine("\r\nList je prázdný");
Console.WriteLine();

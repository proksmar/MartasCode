// See https://aka.ms/new-console-template for more information

using MartasCode;


var townsDb = new TownsDB();

Console.WriteLine("\r\nHledani podle postcode");
var back = townsDb.GetTownByPostCode(89011);
Console.WriteLine(back.Name);


Console.WriteLine("\r\nHledani podle jmena");
var s = townsDb.SearchTown("Ost");
foreach (var town in s)
{
    Console.WriteLine(town.Name);
}


Console.WriteLine("\r\nPridani");
townsDb.AddTown("Praha", 10000 );


Console.WriteLine("\r\nOdebrani");
townsDb.RemoveTown(70800);


Console.WriteLine("\r\nStav na konci");
var s2 = townsDb.GetAll();
foreach (var town in s2)
{
    Console.WriteLine(town.Name);
}

// See https://aka.ms/new-console-template for more information

using MartasCode;

Console.WriteLine("Hello, World!");


var townsDb = new TownsDB();

var back = townsDb.GetTownByPostCode(89011);

Console.WriteLine(back.Name);

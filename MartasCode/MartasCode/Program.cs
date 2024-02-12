// See https://aka.ms/new-console-template for more information

using MartasCode;

Console.WriteLine("Hello, World!");


var townsDb = new TownsDB();

var back = townsDb.GetTown(74601);

Console.WriteLine(back.Name);

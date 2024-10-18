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

{
    var seznam = new List<X>() { new X("A"), new X("B"), new X("C") };
    var seznam2 = new List<string>() { "A", "B","C" };

    var iEnumerable = seznam.AsEnumerable();

    var enumerator = iEnumerable.GetEnumerator();

    enumerator.Reset();//resetuje enumerator na zacatek
    while (enumerator.MoveNext())
    {
        var sss = enumerator.Current; //vraci akutalni polozku na seznamu
        enumerator.Current.Name = enumerator.Current.Name + "X"; //nastavi novou hodnotu na seznamu
        Console.WriteLine(sss);
    }

    

    foreach (var sss in seznam2)
    {
        seznam2[2] = "XXXX";

        Console.WriteLine(sss);
    }

    //enumerator.MoveNext();//posouva se na dalsi polozku (prvni)
    //var ss1 = enumerator.Current; //vraci akutalni polozku na seznamu
    //enumerator.MoveNext();//posouva se na dalsi polozku (druha
    //var ss2 = enumerator.Current; //vraci akutalni polozku na seznamu
    //enumerator.MoveNext();//posouva se na dalsi polozku (druha
    //var ss3 = enumerator.Current; //vraci akutalni polozku na seznamu
    //enumerator.MoveNext();//posouva se na dalsi polozku (druha
    //var ss4 = enumerator.Current; //vraci akutalni polozku na seznamu


    enumerator.Dispose();

}



Console.WriteLine("Hotovo");

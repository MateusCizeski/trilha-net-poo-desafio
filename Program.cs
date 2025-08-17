using DesafioPOO.Models;

Iphone iphone = new Iphone("489999999", "Iphone 6", "12364", 128);
Nokia nokia = new Nokia("489999999", "Nokia 2", "4321", 256);

Console.WriteLine(iphone.Numero);
Console.WriteLine(nokia.Numero);

iphone.Numero = "488999999";
nokia.Numero = "4878999999";

iphone.InstalarAplicativo("Cand crush");
nokia.InstalarAplicativo("Fruit ninja");

Console.WriteLine(iphone.Numero);
Console.WriteLine(nokia.Numero);
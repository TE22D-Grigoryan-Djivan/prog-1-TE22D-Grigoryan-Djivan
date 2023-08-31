// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

Console.Clear();
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Hej, vad heter du?");
string namn = Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Ett ord som beskriver dig?");
string adjektiv = Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Din favorit mat?");
string mat = Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Namn på någon du älskar:");
string älskling = Console.ReadLine();


Console.WriteLine("Hej! "+ namn +" du är " + adjektiv + " tycker " + älskling +". " + älskling +
" har lagat din favorit maträtt " + mat + ", bon appetit!");

Console.ReadLine(); 
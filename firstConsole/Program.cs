// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate}!");
Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);

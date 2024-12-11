// See https://aka.ms/new-console-template for more information
using PasswordGenerator;

Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate}!");
Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);

// Tutorial using a package
var pwd = new Password();
var password = pwd.Next();
Console.WriteLine(password.ToString());

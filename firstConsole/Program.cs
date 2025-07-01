// See https://aka.ms/new-console-template for more information
using PasswordGenerator;

Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate}!");
Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);

// Tutorial using a package found at https://www.nuget.org/packages/PasswordGenerator
var pwd = new Password();
var password = pwd.Next();
Console.WriteLine(password.ToString());


// Methods tutorial from https://learn.microsoft.com/en-ca/training/modules/write-first-c-sharp-method/3-exercise-create-your-first-method
Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
}
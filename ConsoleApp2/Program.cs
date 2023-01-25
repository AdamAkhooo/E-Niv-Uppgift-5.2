using System;
class Program
{
    static void Main(string[]args)
    {
        string[] tal = new string[3];
        tal[0] = "27";
        tal[1] = "420";
        Console.WriteLine($"Skriv valfritt Tal som inte är {tal[0]} och {tal[1]}");
        tal[2] = Console.ReadLine();

        Console.WriteLine("Här är de tre Talen");
        Console.WriteLine($"{tal[0]}, {tal[1]} och {tal[2]}");
    }
}
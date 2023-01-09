using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a random number: ");
        string randomNumber = Console.ReadLine();
        int x = int.Parse(randomNumber);

        Console.WriteLine($"{x}");
    }
}
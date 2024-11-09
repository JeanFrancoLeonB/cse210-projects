using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Select a number between 1 and 100, inclusive: ");
       string response = Console.ReadLine();
       Console.Write("Are you sure you have a number?: ");
       response = Console.ReadLine();
       if (response == "y");
       Console.WriteLine(" I will try to guess your number");
    }
}
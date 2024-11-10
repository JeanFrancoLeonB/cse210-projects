using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string name = textname();
        int number = ingnumber();

        int square = squarenum(number);

        DisplayResult(name, square);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string textname()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int  ingnumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int squarenum(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
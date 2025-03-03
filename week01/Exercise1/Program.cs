using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        

        string first_name;

        Console.Write("What is your first name? ");   /*Writeline hace que el input pase a la siguiente linea, write en la misma*/
        first_name = Console.ReadLine();


        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");

    }
}
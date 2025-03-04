using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        /*    &&  And Operator  !() Not Operator   */

        Console.Write("Enter your Grade please: ");
        string strnumbergrade = Console.ReadLine();
        int numbergrade = int.Parse(strnumbergrade);


        string grade;

        if (numbergrade >= 90)
        {
        grade = "A";
        }
        else if (numbergrade >= 80)
        {
        grade = "B";
        }
        else if (numbergrade >= 70)
        {
        grade = "C";
        }
        else if (numbergrade >= 60)
        {
        grade = "D";
        }
        else
        {
        grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        if (grade ==  "A"  || grade ==  "B" || grade ==  "C" )
        Console.WriteLine($"Congrats, you pass the class !!");
        else
        Console.WriteLine($"Sorry, you didn't pass the class");
    }
}
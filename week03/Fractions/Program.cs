using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction p1 = new Fraction(); // Don't pass any information to get the default values
        Console.WriteLine(p1.GetFractionString());
        Console.WriteLine(p1.GetDecimalValue());

        Fraction p2 = new Fraction(5);  // pass top
        Console.WriteLine(p2.GetFractionString());
        Console.WriteLine(p2.GetDecimalValue());

        Fraction p3 = new Fraction(3, 4); // pass the top and th bottom
        Console.WriteLine(p3.GetFractionString());
        Console.WriteLine(p3.GetDecimalValue());

        Fraction p4 = new Fraction(1, 3);
        Console.WriteLine(p4.GetFractionString());
        Console.WriteLine(p4.GetDecimalValue());
    }
}

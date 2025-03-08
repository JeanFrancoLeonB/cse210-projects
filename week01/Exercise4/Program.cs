using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        /*List<int> numbers = new List<int>();      Crea listas de tipo entero
          List<string> words = new List<string>();  Crea listas de tipo letra

        List<string> words = new List<string>();

        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        Console.WriteLine(words.Count); count the size of the list

        ** Para brindar los elementos dentro 

        foreach (string word in words)
        {
        Console.WriteLine(word);
        }

        Para ingresar a cada uno de los elementos de la lista
        for (int i = 0; i < words.Count; i++)
        {
        Console.WriteLine(words[i]);
        }
        */
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string strnumber = Console.ReadLine();
            number = int.Parse(strnumber);
           /* number = int.Parse(Console.ReadLine()); */

            if (number != 0)
            {
                numbers.Add(number);
            }

        }

        /*
        foreach (int xnumber in numbers)
        {
            Console.WriteLine(xnumber);
        }
        */
        /*Console.WriteLine($"{answer}"); Utilizamos el foreach con el console writeline para devolver los valores de la lista*/

        int sum = 0;

        foreach (int xsum in numbers)
        {
            sum = sum + xsum;
        }
        Console.WriteLine($"The sum is {sum}");
        /* xsum va a tener los valores que muestre la lista, a ellos ira sumando la variable sum que igual se ira agregando en la misma*/

        float avrnumber;
        float lennumber;

        lennumber = numbers.Count;
        avrnumber = sum / lennumber;

        /* double average = (double)sum / numbers.Count;*/

        Console.WriteLine($"The Average number is {avrnumber}");



        
        int max = numbers[0] ;

        foreach (int xmax in numbers)
        {
            if (xmax > max)   /*Si el nuevo valor es mayor que max, lo actualizamos*/

                max = xmax;
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}
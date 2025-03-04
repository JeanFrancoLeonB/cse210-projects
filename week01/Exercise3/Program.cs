using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        /*string response = "yes";

        while (response == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } */



        /* El Do While ejecuta */

        /*
        string response;
        do
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");
        */
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        string answer;


        Console.WriteLine($"The number the computer choose is {number}");
        int guessnumber = -1;
        /*El valor de -1 se agrega para que el while funcione para que pueda comparar
        el numero aleaorio de la computadora con  un valor que no esta dentro
         del rango al inicializar para que la condición que la establecemos sea falsa y
          asi se ejecute el bucle */
        while (number != guessnumber)
        {
            Console.Write("Enter your number please: ");
            string strguessnumber = Console.ReadLine();
            guessnumber = int.Parse(strguessnumber);
        
            if (number > guessnumber)
            {
                answer = "Higher";
            }
            else if (number < guessnumber)
            {
                answer = "Lower";
            }
            else
            {
                answer = "You guessed it!";
            }
             Console.WriteLine($"{answer}");
        }
    }
}
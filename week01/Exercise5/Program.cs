using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        /*
            void DisplayMessage()
            {
                Console.WriteLine("Hello world!");
            }


            DisplayMessage();
            DisplayMessage();
            DisplayMessage();  */

        /*void DisplayPersonalMessage(string userName)
          {
              Console.WriteLine($"Hello {userName}");
          }

          DisplayPersonalMessage("Franco");
          DisplayPersonalMessage("Pily");
          DisplayPersonalMessage("Ruth Esperanza");  */

        /*
        first y second son los parametros, int el tipo de sum que es lo devuelto de la función 
        int AddNumbers(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        Console.WriteLine(AddNumbers(2, 50));
        */

        /*
        En ambos casos se le coloca static para que se pueda llamar facilmente la funcion en otra clase
        static void DisplayMessage()
        {
            Console.WriteLine("Hello world!");
        }

        static void DisplayPersonalMessage(string userName)
        {
            Console.WriteLine($"Hello {userName}");
        }
        */

        static void DisplayWelcome()

        {
            Console.WriteLine("Welcome to the Program !");
        }

        DisplayWelcome();


        static string PromptUserName()
        {

            Console.Write("Please enter your name: ");
            string UserName = Console.ReadLine();

            return UserName;
        }

       


        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;

        }



        static int SquareNumber(int sqrnumber)
        {
            int square = sqrnumber * sqrnumber;

            return square;

        }

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);


        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        DisplayResult(userName, squaredNumber);

    }
}
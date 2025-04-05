using System;
using System.Collections.Concurrent;

class Program
{

    static void Main(string[] args)
    {
        bool esverdad = true;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity:");
            Console.WriteLine("2. Start Reflecting Activity:");
            Console.WriteLine("3. Start Listening Activity:");
            Console.WriteLine("4. Quit:");
            Console.Write("Select a CHoice from menu:");
            int eligenumero = int.Parse(Console.ReadLine());

            switch (eligenumero)
            {
                case 1:
                    BreathingActivity Breath = new BreathingActivity();
                    Breath.Run();
                    break;
                case 2:
                    ReflectingActivity Reflect = new ReflectingActivity();
                    Reflect.Run();
                    break;
                case 3:
                    ListingActivity Listing = new ListingActivity();
                    Listing.Run();
                    break;
                case 4:
                    esverdad = false;
                    Console.WriteLine("Thanks for use the program");
                    break;
                /*default es cuando el usuario elige una opcion erronea*/
                default:
                    Console.WriteLine("Opción no válida, ingrese una opción disponible");
                    break;
            }
        } while (esverdad);
    }
}

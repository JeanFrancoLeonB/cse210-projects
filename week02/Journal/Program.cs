using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal TheJournal = new Journal();
        /*Entry TheEntry = new Entry(pregunta, respuesta);
        TheEntry.Display();*/

        bool condicion = true;

        do
        {

            Console.WriteLine($"Welcome to the Journal Porgram !");
            Console.WriteLine($"Please Select one of the following choices");

            Console.WriteLine($"1. Write");
            Console.WriteLine($"2. Display");
            Console.WriteLine($"3. Load");
            Console.WriteLine($"4. Save");
            Console.WriteLine($"5. Quit");
            Console.Write("What would you like to do?");
            int eligenumero = int.Parse(Console.ReadLine());


            switch (eligenumero)
            {
                case 1:
                    string casowrite = PromptGenerator.GetRandomPrompt();
                    Console.WriteLine($"{casowrite}");
                    Console.Write(">");
                    string escriturarespuesta = Console.ReadLine();

                    Entry TheEntry = new Entry(casowrite, escriturarespuesta);
                    TheJournal.AddEntry(TheEntry);

                    break;
                case 2:
                    TheJournal.DisplayAll();
                    break;
                case 3:
                    Console.Write("Escribe el nombre de tu archivo a cargar:");
                    string archivocargar = Console.ReadLine();

                    TheJournal.LoadFromFile(archivocargar);
                    break;
                case 4:
                    Console.Write("Escribe el nombre de tu archivo a guardar:");
                    string archivoguardar = Console.ReadLine();

                    TheJournal.SaveToFile(archivoguardar);
                    break;
                case 5:
                    condicion = false;
                    break;

                    /*default es cuando el usuario elige una opcion erronea*/
                default:
                    Console.WriteLine("Opción no válida, ingrese una opción disponible");
                    break;
            }

        }while (condicion);
    }
}
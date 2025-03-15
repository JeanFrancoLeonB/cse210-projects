public class Entry
{


    public string _date = "";
    public string _promptText = "";

    public string _entryText = "";


    public Entry(string pregunta, string respuesta)
    {
         _date = DateTime.Now.ToShortDateString();

       /* DateTime fecha = DateTime.Now;
        string _date = fecha.ToShortDateString();*/
        _promptText = pregunta;
        _entryText = respuesta;


    }

    public void Display()
    {

        Console.WriteLine ($"Date {_date} - Prompt:  {_promptText} \n {_entryText}.");
        
        /*
        Console.WriteLine($"Welcome to the Journal Porgram !");
        Console.WriteLine($"Please Select one of thefollowing choices");
        Console.WriteLine($"1. Write");
        Console.WriteLine($"2. Display");
        Console.WriteLine($"3. Load");
        Console.WriteLine($"4. Save");
        Console.WriteLine($"5. Quit");
        Console.Write("What would you like to do?");
        int eligenumero = int.Parse(Console.ReadLine());*/
    }
}
using System;
// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO;
public class Journal
{

    private List<Entry> _entries = new List<Entry>();


    /* sobrenombre de la clase Entry porque nos encontramos en la clase journal */
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }


    public void DisplayAll()
    {
      
    }








    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            /* ALineas clase Job, luego todotrabajos nombre cualquiera, lista _jobs*/
            foreach (Entry entradas in _entries)
            {
                string cadena = $"{entradas._date}-{entradas._promptText}-{entradas._entryText}";
                outputFile.WriteLine(cadena);

            }
        }
        Console.WriteLine($"Guardado Exitosamente");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine($"El archivo no existe");
            return;
        }
        /*Limpia la lista Entries*/
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("-");

            string fecha = parts[0];
            string preguntas = parts[1];
            string respuestas = parts[2];

            Entry e = new Entry(preguntas, respuestas)
            {
                _date = fecha
            };
            _entries.Add(e);


        }
        Console.WriteLine($"Guardado con Exito");
    }

}
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
    
    }
}
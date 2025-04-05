using System.Data;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private int _count;

    private static List<string> _prompts = new List<string>(){
    "When have you felt the Holy Ghost this month?",
    "When have you felt the Holy Ghost this week?",
    "When have you felt the Holy Ghost this morning?",
    "When have you felt the Holy Ghost this day?"
   };

    public ListingActivity()
    {
        _name = "Welcome to Listing Activity";
        _description = "This activity will help you reflect on the good things in your life having you list as many things as you can in a certain area";
        _count = 0;
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        ShowSpinner(2);
        List<string> lista = GetListFromUser();
        Console.WriteLine($"Your answer are {lista.Count()}");
         foreach (string x in lista)
        {
            Console.WriteLine(x);
        }
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random aleatorio = new Random();

        string random = _prompts[aleatorio.Next(_prompts.Count)];

        Console.WriteLine(random);
    }
    public List<string> GetListFromUser()
    {
        List<string> lista = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

       Console.WriteLine("You may begin in");

       while (DateTime.Now <= futureTime){
        Console.Write("_");
        string variable = Console.ReadLine();
        if (!string.IsNullOrEmpty(variable)){
            lista.Add(variable);
        };
         _count ++;
       }
        return lista;
    }
}



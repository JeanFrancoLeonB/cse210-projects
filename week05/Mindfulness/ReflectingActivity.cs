using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private static List<string> _questions = new List<string>(){
    "How did you feel when it was complete ?",
    "What is your favorite thing about this experience?",
    "How do you feel now?",
    "Do you want to retake this experience?"
   };
    private static List<string> _prompts = new List<string>(){
    "Think of a time when you did something really difficult",
    "Think of a time when you did something challenging",
    "Think of a time when you didnt regret",
    "Think of a time when you did something sucsessfully"
   };



    public ReflectingActivity()
    {
        _name = "Welcome to Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
    }
    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        ShowSpinner(3);
        DisplayQuestion();
        ShowSpinner(3);
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random aleatorio = new Random();

        string random = _prompts[aleatorio.Next(_prompts.Count)];
        return random;
    }
    public string GetRandomQuestion()
    {
        Random aleatorio = new Random();

        string random = _questions[aleatorio.Next(_questions.Count)];
        return random;
    }
    public void DisplayPrompt()
    {
        string desarrollo = GetRandomPrompt();
        Console.WriteLine($"---{desarrollo}---");
    }

    public void DisplayQuestion()
    {
        string desarrollo = GetRandomQuestion();
        Console.WriteLine($"---{desarrollo}---");
    }
}


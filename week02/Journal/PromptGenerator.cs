public class PromptGenerator
{

    /*public List<string> _prompts = new List<string>;*/
    private static List<string> _prompts = new List<string>
    {
        "If I had one thing I could do over today, what would it be?",
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "What is something I learned today?",
        "What am I grateful for today?",
        "What was the biggest challenge I faced today?",
        "What made me smile or laugh today?",
        "What am I looking forward to tomorrow?"
    };

    public static string GetRandomPrompt()
    {
        Random aleatorio = new Random();

        int i = aleatorio.Next(_prompts.Count);

        string promptaleatorio = _prompts[i];

        return promptaleatorio;
    }



}
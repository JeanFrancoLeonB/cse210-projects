
using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Welcome to Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(_duration);
        int duracion = _duration;

        while (duracion > 0)
        {
            Console.WriteLine($"\n Breathe in....");
            ShowSpinner(3);

            duracion -= 3;

            if (duracion <= 0)
            {
                break;
            }
            Console.WriteLine($"\n Now Breathe out....");
            ShowSpinner(3);

            duracion -= 3;
        }

        DisplayEndingMessage();
    }
}    

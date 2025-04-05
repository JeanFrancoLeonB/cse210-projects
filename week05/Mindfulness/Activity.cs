public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine($"Description {_description}");

        Console.Write($"How long do you want to dure this activity: ");
        _duration = int.Parse(Console.ReadLine());


    }
    public void DisplayEndingMessage()
    {
        Console.Write($"Well done !");
        Console.Write($"You have completed {_duration} seconds of Reflecting Activity");
        Thread.Sleep(1000);

    }
    public void ShowSpinner(int seconds)
    {
        int _segundos = seconds * 2;

        for (int i = 0; i < _segundos; i++)
        {
            string[] iteracion = { "/", "-", "\\", "|" };
            Console.Write($"{iteracion[i % iteracion.Length]}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
       
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i>0; i--)
        {
            Console.WriteLine($"Counting the {i} seconds");
            Thread.Sleep(1000);
        }
    }
}

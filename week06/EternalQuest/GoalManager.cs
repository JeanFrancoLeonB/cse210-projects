using System;
using System.ComponentModel;
public class GoalManager
{
    private static List<Goal> _goals = new List<Goal>();
    private int _score = 0;



    public GoalManager()
    {
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int Score)
    {
        _score = Score;
    }
    public void Start()
    {
        bool started = true;
        while (started)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Quit:");
            Console.Write("Select a CHoice from menu:");
            int eligenumero = int.Parse(Console.ReadLine());
            switch (eligenumero)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    started = false;
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }
    public void ListGoalName()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._shortname}");
        }


    }
    public void ListGoalDetails()
    {

        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goals would you like to create?");
        int eligenumerometa = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal?:");
        string eligenombremeta = Console.ReadLine();
        Console.Write("What is a short description of it?:");
        string eligedescripcionmeta = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?:");

        string eligepuntosmeta = Console.ReadLine();

        switch (eligepuntosmeta)
        {
            case "1":
                Goal meta = new SimpleGoal(eligenombremeta, eligedescripcionmeta, eligepuntosmeta);
                _goals.Add(meta);
                break;
            case "2":
                Goal eternameta = new EternalGoal(eligenombremeta, eligedescripcionmeta, eligepuntosmeta);
                _goals.Add(eternameta);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus?:");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times?:");
                int bonus = int.Parse(Console.ReadLine());

                Goal checkmeta = new CheckListGoal(eligenombremeta, eligedescripcionmeta, eligepuntosmeta, target, bonus);
                _goals.Add(checkmeta);
                break;
        }
    }
    public void RecordEvent()
    {
        ListGoalName();
        Console.Write("Which goal did you acoomplish?");
        int metas = int.Parse(Console.ReadLine()) - 1;

        if (metas >= 0 && metas < _goals.Count)
        {
            _goals[metas].RecordEvent();
            _score += int.Parse(_goals[metas]._points);
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file?");
        string file = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            /* ALineas clase Job, luego todotrabajos nombre cualquiera, lista _jobs*/
            outputFile.WriteLine(_score);
            foreach (Goal metas in _goals)
            {
                string cadena = metas.GetStringRepresentation();
                outputFile.WriteLine(cadena);

            }
        }
        Console.WriteLine($"Guardado Exitosamente");
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file?");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine($"El archivo no existe");
            return;
        }
        /*Limpia la lista Entries*/
        _goals.Clear();

        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            string tipogoal = parts[0];
            switch (tipogoal)
            {
                case "Simple":
                    string shortname = parts[1];
                    string description = parts[2];
                    string puntaje = parts[3];

                    SimpleGoal simple = new SimpleGoal(shortname, description, puntaje);
                    string afirmacion = parts[4];

                    if (afirmacion == "Complete")
                    {
                        simple.RecordEvent();
                    }
                    _goals.Add(simple);
                    break;
                case "Eternal":
                    string shortname1 = parts[1];
                    string description1 = parts[2];
                    string puntaje1 = parts[3];
                    EternalGoal eternal = new EternalGoal(shortname1, description1, puntaje1);
                    _goals.Add(eternal);
                    break;
                case "CheckList":
                    string shortname2 = parts[1];
                    string description2 = parts[2];
                    string puntaje2 = parts[3];
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);

                    CheckListGoal checkList = new CheckListGoal(shortname2, description2, puntaje2, target, bonus);

                    for (int j = 0; j < amountCompleted; j++)
                    {
                        checkList.RecordEvent();
                    }
                    _goals.Add(checkList);
                    break;
            }
        }
    }
}

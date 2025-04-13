using System;
public class SimpleGoal : Goal
{
    private bool _isComplete = true;



    public SimpleGoal(string shortname, string description, string points) : base(shortname, description, points)
    {
        _isComplete = false;
    }


    public override void RecordEvent()
    {
        if (!_isComplete) {
          _isComplete = true;
            Console.WriteLine ($"Objetivo {_shortname} Cumplido. Tu has ganado {_points} points");
        }
        else {
             Console.WriteLine($"Objetivo {_shortname} ya Cumplido");
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override  string GetStringRepresentation()
    {
        /*El interrogacion significa el if y el dos puntos la comparacion */
        string linea=$"Simple|{_shortname}|{_description}|{_points}|{(IsComplete()?"Complete" : "En Proceso")}";
        return linea;
    }

}


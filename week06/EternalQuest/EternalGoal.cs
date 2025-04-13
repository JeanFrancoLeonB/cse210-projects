using System;
public class EternalGoal : Goal
{

    public EternalGoal(string shortname, string description, string points) : base(shortname, description, points)
    {

    }


    public override void RecordEvent(){
        Console.WriteLine($"Objetivo {_shortname} Cumplido. Tu has ganado {_points} points");
    }
    public override bool IsComplete(){
        return false;
    }
    public override string GetStringRepresentation(){
         string linea=$"Eternal|{_shortname}|{_description}|{_points}";
        return linea;
    }

}

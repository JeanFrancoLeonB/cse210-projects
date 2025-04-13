using System;
public class CheckListGoal : Goal
{
    public int _amountCompleted { get; private set; }= 0;
    public int _target { get; private set; }= 0;
    public int _bonus { get; private set; } = 0;



    public CheckListGoal(string shortname, string description, string points, int target, int bonus) : base(shortname, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target ){
            _amountCompleted = _amountCompleted++;
            Console.WriteLine($"Objetivo {_shortname} Cumplido. Tu has ganado {_points} points");
            if(_amountCompleted == _target){
                int puntos = int.Parse(_points) + _bonus;
                Console.WriteLine($"Objetivo {_shortname} Cumplido. Tu has ganado {puntos} points");
            }
            else{
                Console.WriteLine($"Objetivo {_shortname} Cumplido.");
            }
        }
    }
    public override bool IsComplete()
    {
        return false;
    }
   public override string GetDetailsString()
    {
        /*los dos puntos representan al else y el signo de interrogacion al if*/
        string mensage = $"[{(IsComplete()?"X":" " )}] {_shortname}({_description})--Currently completed: {_amountCompleted} / {_target} ";
        return mensage;
    }
    public override string GetStringRepresentation()
    {
        string linea=$"Checklist|{_shortname}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
        return linea;
    }

}

using System;
public abstract class Goal
{
    public string _shortname { get; private set; } = "";
    public string _description { get; private set; } = "";
    public string _points { get; protected set; } = "";


    public Goal(string shortname, string description, string points)
    {
        _shortname = shortname;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string mensage = $"[{(IsComplete()?"X":" " )}] {_shortname}({_description})";
        return mensage;

    }
    public abstract string GetStringRepresentation();


}
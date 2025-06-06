public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes() => _minutes;
    public string GetDate() => _date.ToString("dd MMM yyyy");

    public abstract double GetDistance(); // km
    public abstract double GetSpeed(); // km/h
    public abstract double GetPace(); // min/km

    public virtual string GetSummary()
    {
        return $"{GetDate()} {this.GetType().Name} ({_minutes} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}
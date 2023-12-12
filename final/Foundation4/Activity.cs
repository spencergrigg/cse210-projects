public abstract class Activity{
    private string _date;
    private int _minutes;
    private string _type;

    public Activity(string date, int minutes, string type){
        _date = date;
        _minutes = minutes;
        _type = type;
    }
    public virtual void GetSummary(){
        Console.WriteLine($"{_date} {_type} ({_minutes} min)- Distance {Math.Round(GetDistance(), 2)} miles, {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace())} min per mile");
    }

    public double GetMinutes(){
        return _minutes;
    }

    public virtual double GetDistance(){
        return 0;
    }

    public virtual double GetSpeed(){
        return (GetDistance() / _minutes) * 60;
    }

    public virtual double GetPace(){
        return _minutes / GetDistance();
    }

}
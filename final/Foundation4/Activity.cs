public abstract class Activity{
    private string _date;
    private int _minutes;
    private string _type;
    private double _record;

    public Activity(string date, int minutes, string type, double record){
        _date = date;
        _minutes = minutes;
        _type = type;
        _record = record;
    }
    public virtual void GetSummary(){
        Console.WriteLine($"{_date} {_type} ({_minutes} min)- Distance {Math.Round(GetDistance(), 2)} miles, {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace())} min per mile, Previous Record: {_record}mpm... {CalculateRecord()}");
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

    public string CalculateRecord(){
        if (_record <= GetPace())
        {
            return "Keep working. You got this!";
        }
        else
        {
            return "Nice job! You set a new record today!";
        }
    }

}
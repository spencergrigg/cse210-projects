public class Running : Activity{
    private double _distance;

    public Running(string date, int minutes, double distance, string type, double record): base(date, minutes, type, record){
        _distance = distance;        
    }

    public override void GetSummary()
    {
        base.GetSummary();
        Console.WriteLine();
    }

    public override double GetDistance(){
        return _distance;
    }

    public override double GetSpeed(){
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace(){
        return GetMinutes() / GetDistance();
    }

}
using System.Data;

public class Cycling : Activity{
    private double _speed;

    public Cycling(string date, int minutes, double speed, string type, double record): base(date, minutes, type, record){
        _speed = speed;        
    }

    public override double GetDistance(){
        return (_speed * GetMinutes()) / 60;
    }

    public override double GetSpeed(){
        return _speed;
    }

    public override double GetPace(){
        return GetMinutes() / GetDistance();
    }


}
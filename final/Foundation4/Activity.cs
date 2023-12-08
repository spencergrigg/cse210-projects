public abstract class Activity{
    private string _date;
    private int _minutes;
    private List<Activity> _activities = new List<Activity>();

    public Activity(string date, int minutes){

    }
    public virtual void GetSummary(){
        //Produce a string with summary information
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    }

    public virtual void GetDistance(){
        
    }

    public virtual void GetSpeed(){
        
    }

    public virtual void GetPace(){
        
    }

    //Speed = (distance / minutes) * 60
    //Pace (min per km) = minutes / distance
    //Speed = 60/ pace
    //Pace = 60 / speed
}
public abstract class Goal{

    //Member Variables
    private string _shortName;
    private string _description;
    private int _points;

    //Constructor
    public Goal(string name, string description, int points){
        _shortName = name;
        _description = description;
        _points = points;
    }

    //Behaviors
    public abstract void RecordEvent();
        //Mark a goal complete or add tick to checklist 
        //& return the point value with completingthe event
    public abstract bool IsComplete();
        //Should return true if complete
    public abstract string GetDetailsString();
        //Return the details of a goal that could be shown in a list
        //It should include the checkbox, short name & description
        //Then checklist should overide to show the number of times the goal has been accomplished
    public abstract string GetStringRepresentation();
        //Should provide all details of goal to be easy to save to a file and then load later
}
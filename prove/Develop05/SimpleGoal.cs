using System.Runtime.CompilerServices;

public class SimpleGoal : Goal{
    //Member Variables
    private bool _isComplete;

    //Constructor
    public SimpleGoal(string name, string description, int points): base(name, description, points){
        _isComplete = false;
    }
    //Behaviors
    public override void RecordEvent(){
        
        bool input = Console.ReadLine();
        _isComplete = true;
    }
    public override bool IsComplete(){

    }
    public override string GetStringRepresentation(){

    }

}
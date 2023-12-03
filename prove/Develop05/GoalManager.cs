using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

public class GoalManager{
    //Member variables
    private List<Goal> _goals;
    private int _score;

    //Constructor
    public GoalManager(){
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        //runs menu loop
        string menu = $@"
Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Please select a choice from the menu: ";
        
        string input = "";
        while (input != "6")
        {
            Thread.Sleep(3000);
            Console.Clear();
            DisplayPlayerInfo();
            Console.Write(menu);
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //Create New Goal
                    break;

                case "2":
                    //List Goals
                    break;

                case "3":
                    //Save Goals
                    break;

                case "4":
                    //Load Goals
                    break;

                case "5":
                    //Record Event
                    break;

                case "6":
                    Console.Write("Goodbye...");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        //Lists the name of each goal
    }

    public void ListGoalDetails()
    {
        //Lists details of each goal including the checkbox
    }

    public void CreateGoal()
    {
        //Asks the user for info @ new goal. Then creates goal and adds to list
    }

    public void RecordEvent()
    {
        //Asks the user which goal they have done $ records event by calling the RecordEvent method on that goal
    }

    public void SaveGoals()
    {
        //Saves list of goals to file
    }

    public void LoadGoals()
    {
        //Loads the list of goals from a file.
    }



}
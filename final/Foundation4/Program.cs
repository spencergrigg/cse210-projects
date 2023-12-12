using System;

class Program
{
    static void Main(string[] args)
    {
        //Creates each subActivity object
        Running running1 = new Running("1/1/1011", 65, 8, "Running", 6);
        Cycling cycling1 = new Cycling("2/2/2022", 120, 18, "Cycling", 4);
        Swimming swimming1 = new Swimming("3/3/3033", 20, 10, "Swimming", 60);

        //Creates Activity List and adds all subActivites
        List<Activity> activities = new List<Activity>();
        activities.Add(running1);
        activities.Add(cycling1);
        activities.Add(swimming1);

        //Output Code
        //Welcomes User
        Console.Clear();
        Console.WriteLine("Hello! Welcome to the activity tracking app! Here you will see your stats for running, cyling and swimming");
        Console.WriteLine("---------------------------------Activities---------------------------------");

        //Display a summary of the Activity List
        foreach (Activity item in activities)
        {
            item.GetSummary();
        }

        //Tell the user Goodbye
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Thank you for using the fitness app. Come again!");
    }
}
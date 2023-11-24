using System;

class Program
{
    static void Main(string[] args)
    {
Console.Clear();
Console.WriteLine("Welcome to the Mindfulness App™");
        string menu = @"
Menu Options:
    1. Start breathing activity
    2. Start reflection activity
    3. Start Listing activity
    4. Quit
Select a choice from the menu: ";
        Console.Write(menu);
        string option = Console.ReadLine();

        while (option != "4")
            {
                switch (option) 
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Run();
                        break;
                    case "2":
                        ReflectionActivity reflection = new ReflectionActivity();
                        reflection.Run();
                        break;
                    case "3":
                        ListingActivity listing = new ListingActivity();
                        listing.Run();
                        break;
                    default:
                        Activity defaultAct = new Activity();
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    }
                Console.Write(menu);
                option = Console.ReadLine();
            }
        Console.Write("Goodbye...");
    }

}

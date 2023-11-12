using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        //Establishes an object for the PromptGenerator class
        PromptGenerator thePrompt = new PromptGenerator();
        
        //Establishes an object for the Entry class 
        Entry anEntry = new Entry();
        

    
        //establishes code for theJournal class and functions
        Journal theJournal = new Journal();
        theJournal._entries = new List<Entry>();


        //User run code
        Console.WriteLine("Welcome to the Journal App");
        string menu = @"Please select one of the following choices:
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit
        What would you like to do?";
        Console.WriteLine(menu);
        string option = Console.ReadLine();

        while (option != "5")
            {
                switch (option) 
                {
                    case "1":
                        anEntry._promptText =  thePrompt.GetRandomPrompt();
                        anEntry._date = (DateTime.Now).ToShortDateString();
                        Console.WriteLine(anEntry._promptText);
                        anEntry._entryText = Console.ReadLine();
                        theJournal.AddEntry(anEntry);
                        //anEntry.Display();
                        
                        break;
                    case "2":
                        theJournal.DisplayAll();
                        break;
                    case "3":
                        Console.WriteLine("Please enter the name of the file.");
                        string fileName = Console.ReadLine();
                        theJournal.LoadFromFile(fileName);
                        break;
                    case "4":
                        Console.WriteLine("Please enter the name of the file.");
                        string saveFile = Console.ReadLine();
                        theJournal.SaveToFile(saveFile);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
                        break;
                    }
                Console.WriteLine(menu);
                option = Console.ReadLine();
            }
        Console.Write("Goodbye...");
    }
}

//Write a new entry - Show the user a random prompt, save the respons, the prompt, and the date as an Entry
//Display the journal - Iterate through all entries in the journal and display to the screen
//Save the journal to a file - Prompt the user for a filename and save the current journal (all entries) to that file location
//Load the journal from a file - Get filename & load the journal (all entries from the file). This should replace any entries currently stored in the journal
//Provide a menu that allows the user to choose these options

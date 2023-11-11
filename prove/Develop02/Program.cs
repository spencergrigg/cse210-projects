using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        
        anEntry.Display();
    }
}

//Write a new entry - Show the user a random prompt, save the respons, the prompt, and the date as an Entry
//Display the journal - Iterate through all entries in the journal and display to the screen
//Save the journal to a file - Prompt the user for a filename and save the current journal (all entries) to that file location
//Load the journal from a file - Get filename & load the journal (all entries from the file). This should replace any entries currently stored in the journal
//Provide a menu that allows the user to choose these options

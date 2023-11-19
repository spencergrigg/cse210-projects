using System;

class Program
{
    static void Main(string[] args)
    {
    
    //Welcomes the user and explains the program
    Console.WriteLine("Welcome to the Scripture Memorizer Program!");
    Console.WriteLine("--------------------------------------------------------------------------");


    //Creates objects for the Reference and Scripture classes
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture1 = new Scripture(reference1, "Lean not unto thine understanding, but look unto the Lord.");

        //Executes the program
        string originalInput = Console.ReadLine();
        while (Console.ReadLine() != "quit"){
            //scripture1.IsCompletelyHidden();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            Console.Write($"{reference1.GetDisplayText()} ");
            Console.WriteLine(scripture1.GetDisplayText());
            scripture1.HideRandomWords(3);
        }
        
    Console.WriteLine("--------------------------------------------------------------------------");

    //Reference class testing
        // Reference reference2 = new Reference("Proverbs", 3, 5);
        // Console.WriteLine(reference2.GetDisplayText());
    
    //Word class testing
        // Word word1 = new Word("Word");
        // word1.Show();
        // Console.WriteLine("");
        
        // word1.Hide();
        // Console.WriteLine("");
        
        // word1.Show();
        // Console.WriteLine("");
        
        // Console.WriteLine(word1.IsHidden());
        // Console.WriteLine(word1.GetDisplayText());

        // Word word2 = new Word("Word");
        // Console.Write(word2.IsHidden());
        // word2.Hide();
        // Console.Write(word2.IsHidden());    

    //Scripture class testing
        // Console.WriteLine(scripture1.GetDisplayText());
        // scripture1.HideRandomWords(1);
        // Console.WriteLine(scripture1.GetDisplayText());
        // scripture1.IsCompletelyHidden();
    }

}
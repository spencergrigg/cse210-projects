using System;

class Program
{
    static void Main(string[] args)
    {

    //Creates objects for the Reference and Scripture classes
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture1 = new Scripture(reference1, "Lean not unto thine understanding, but look unto the Lord.");

        Reference reference2 = new Reference("Abraham", 3, 24, 26);
        Scripture scripture2 = new Scripture(reference2, @"
    Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones;

    And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born.
And there stood one among them that was like unto God, and he said unto those who were with him: We will go down, for there is space there, and we will take of these materials, and bwe will make an earth whereon these may dwell;

    And we will prove them herewith, to see if they will do all things whatsoever the Lord their God shall command them;
And they who keep their first estate shall be added upon; and they who keep not their first estate shall not have glory in the same kingdom with those who keep their first estate; and they who keep their second cestate shall have glory added upon their heads for ever and ever.");
    //Welcomes the user and explains the program
    Console.WriteLine("--------------------------------------------------------------------------");
    Console.WriteLine("Welcome to the Scripture Memorizer Program! Please press enter to start:");


        //Executes the program
        // string originalInput = Console.ReadLine();
        while (Console.ReadLine() != "quit"){
            Console.Clear();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: \n");
            Console.Write($"{reference2.GetDisplayText()} ");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine(scripture2.GetDisplayText());
            scripture2.IsCompletelyHidden();
            scripture2.HideRandomWords(3);
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
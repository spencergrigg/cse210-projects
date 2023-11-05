using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome! Guess a number from 1-100. ");
        Random numberGenerator = new();
        int number = numberGenerator.Next(1,101);
        
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());
        
        while (number != guess)
        {
            if (number > guess)
            {
                Console.WriteLine("Higher");
            }

            if (number < guess)
            {
                Console.WriteLine("Lower");
            }
        
        //Ask for a new guess
        Console.Write("What is your new guess? ");
        guess = int.Parse(Console.ReadLine());
        
        }    
        
        Console.WriteLine("You guessed it!");
    }
}

//        Random randomGenerator = new();
//        int number = randomGenerator.Next(1, 11);
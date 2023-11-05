using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);

        //Displays welcome message
        static void DisplayWelcome()
            {
                Console.WriteLine("Welcome to the program!");
            }
        
        //Stores user's name in a variable
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        //Stores user's number in a variable
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        //Accepts a number and squares it
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        //Displays user's name and squared number
        static void DisplayResult(string name, int square)
        {
            Console.Write($"{name}, the square of your number is {square}");
        }


    }
}
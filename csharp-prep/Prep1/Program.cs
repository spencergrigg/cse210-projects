using System;

class Program
{
    static void Main(string[] args)
    {
        //Store First Name
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        //Store Last Name 
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine(); 

        //Print result
        Console.WriteLine($"Your name is {last}, {first} {last}.");   
    }
}
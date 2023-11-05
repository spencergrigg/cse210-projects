using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string letter = "N";
        bool pass = true;

        //Get Grade from user
        Console.Write("Hello! Please enter your score from 0-100: ");
        int score = int.Parse(Console.ReadLine());
        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Determine if the student passed
        if (score < 70)
        {
            pass = false;
        }

        //Print results
        Console.WriteLine("---------------------------------------------------------------------------------------------------");
        Console.WriteLine($"You earned a {letter}");
        if (pass)
        {
            Console.WriteLine("You passed the class! Congrats!");
        }
        else
        {
            Console.WriteLine("You did not pass the course. Remember, help is always offered. Try again when you're ready!");
        }
        Console.WriteLine("---------------------------------------------------------------------------------------------------");

    }
}
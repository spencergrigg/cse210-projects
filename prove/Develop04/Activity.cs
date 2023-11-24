using System;
using System.Runtime.CompilerServices;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.Write($@"
Welcome to the {_name} Activity.

{_description}

How long, in seconds, would you like for your session? ");
    }
    
    public void DisplayEndingMessage()
    {
        Console.Write($"Well done! Thank you for using our Mindfulness App.");
        Thread.Sleep(5000);
        Console.Clear();
    }
    
    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();

        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("–");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        if (seconds != 101)
        {
            Console.WriteLine("Get ready..."); 
        }
        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

        if (i >= animationString.Count)
        {
            i = 0;
        }
        }
        Console.WriteLine("");
    }

public void ShowBreath(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        Console.Write("()");
        while (DateTime.Now < endTime){
            Thread.Sleep(1000);
            Console.Write("\b )");
            i++;
        }
        Console.WriteLine("");
    }

public void ShowExhale(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        Console.Write("(     )"); 
        while (DateTime.Now < endTime){
            Thread.Sleep(1000);
            Console.Write("\b\b) \b");
            i++;
        }
        Console.WriteLine("");
    }


    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }    
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
}
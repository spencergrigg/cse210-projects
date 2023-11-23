using System;
public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;
    
    public void DisplayStartingMessage(){
    }
    
    private void DisplayEndingMessage(){

    }
    
    public void ShowSpinner(int seconds){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        List<string> animationStrings = new List<string>();

        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("–");
        animationStrings.Add("\\");


        while (DateTime.Now < endTime){
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            //Console.Write("\b \b");
            i++;

        if (i >= animationStrings.Count){
            i = 0;
        }
        }
    }
    public void ShowCountDown(int second){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(second);

        Thread.Sleep(3000);

    DateTime currentTime = DateTime.Now;
    if (currentTime < futureTime)
        {
            Console.WriteLine("We have not arrived at our future time yet...");
        }
    }
    
    public Activity(string name, string description, int duration){
        _name = name;
        _description = description;
        _duration = duration;
    }
}
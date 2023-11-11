using System.ComponentModel.DataAnnotations;


public class Entry
{
    //public DateTime theCurrentTime = DateTime.Now;
    public string _date;
    public string _promptText;
    public string _entryText;
    //public Entry()
    //{
    //    _date = theCurrentTime.ToShortDateString();
    //}

    //PromptGenerator prompt = new PromptGenerator();
    //_promptText = prompt.GetRandomPrompt();
    

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText} \n {_entryText}");
    }
}

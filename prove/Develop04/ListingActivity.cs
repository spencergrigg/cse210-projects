public class ListingActivity : Activity{
    private int _count;
    private List<string> _prompts = new List<string>();
    public ListingActivity() : base() {
         _name = "Reflecting";
         _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
     }
    public void Run(){
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        GetPrompt();
        DisplayPrompt();
        ShowSpinner(5);
        GetList();
        DisplayEndingMessage();

    }

    public string GetPrompt(){
        Random randomNumber = new ();
        int index = randomNumber.Next(_prompts.Count);
        return _prompts[index];

    }
    public void DisplayPrompt(){
        Console.WriteLine($" ——— {GetPrompt()} ——— ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void GetList(){
        int responseCount = 0;
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
        Console.Write("> ");
        Console.ReadLine();
        responseCount ++;
        }

        Console.WriteLine($"Well done! You wrote {responseCount} entries.");
        Thread.Sleep(2000);
    }
}


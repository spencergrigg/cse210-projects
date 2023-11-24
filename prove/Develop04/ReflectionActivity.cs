public class ReflectionActivity : Activity
{

    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectionActivity() : base() {
         _name = "Reflecting";
         _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("How did you get started?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("Why was this experience meaningful to you?");

     }

    public void Run(){
        DisplayStartingMessage();
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        GetPrompt();
        DisplayPrompt();
        GetRandomQuestion();
        DisplayQuestions();
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
    public string GetRandomQuestion(){
        Random randomNumber = new ();
        int index = randomNumber.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayQuestions(){
        Console.WriteLine("You may begin in: "); ShowCountDown(5);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
        Console.Write($"> {GetRandomQuestion()} ");
            Console.ReadLine();
            //ShowSpinner(101);
        }
    }
}

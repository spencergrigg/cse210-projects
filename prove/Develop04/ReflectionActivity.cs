public class ReflectionActivity //: Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    // public ReflectingActivity(){
    //     _name = "Reflecting";
    //     _description = "This activity will help you reflect on times ...";
    //     _duration = 50;
    // }

    //public void Run();
    public string GetPrompt(){
        Random randomNumber = new ();
        int index = randomNumber.Next(_prompts.Count);
        return _prompts[index];
    }
    public void DisplayPrompt(){
        Console.WriteLine(GetPrompt());
    }
    public string GetRandomQuestion(){
        Random randomNumber = new ();
        int index = randomNumber.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayQuestions(){
        Console.WriteLine(GetPrompt());
    }
}
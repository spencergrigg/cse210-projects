public class Comment{
    
    //Variables
    private string _name;
    private string _text;

    //Constructor
    public Comment(string userName, string commentText){
        _name = userName;
        _text = commentText;
    }

    public void DisplayComment(){

    Console.WriteLine($"{_name} - \"{_text}\" ");
    //Console.WriteLine($"Comment: \"{_text}\" ");

    }
}
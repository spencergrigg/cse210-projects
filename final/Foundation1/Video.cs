public class Video{
    
    //Variables
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> _comments = new List<Comment>();

    //Constructor
    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
        
    }

    //Methods
    public int GetCommentTotal(){
        int _total = 0;
        foreach (Comment item in _comments)
        {
            _total += 1;
        }
        return _total;
    }

    public void DisplayVideoInfo(){
        Console.WriteLine(@$"
Title: {_title}
Author: {_author}
Length: {_length} seconds
Number of Comments: {GetCommentTotal()}
--------------------------Comments--------------------------");
foreach (Comment item in _comments)
{
    item.DisplayComment();
}
Console.Write($"-----------------------Next Video-----------------------");
    }
}
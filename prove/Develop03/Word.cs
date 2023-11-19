//Keeps track of a single word and whether it is shown or hidden.
class Word{
    private string _text;
    private bool _isHidden;

    public Word(string text){
        _text = text;
        _isHidden = IsHidden();
    }

    public void Hide(){
        _text = new string('_', _text.Length);
        Console.Write($"{_text} ");
    }

    public void Show(){
        Console.Write($"{_text} ");
    }

    public bool IsHidden(){
        if (_text.Contains("_")){
        return true;
        }
        else{
            return false;
        }
    }

    public string GetDisplayText(){
        return _text;
    }
}
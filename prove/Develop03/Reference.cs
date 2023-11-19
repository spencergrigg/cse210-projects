//Keeps track of the book, chapter, and verse information.
class Reference{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText(){
        if (_endVerse != 0){
            string referenceText = $"{_book} {_chapter}:{_verse}-{_endVerse}"; 
            return referenceText;
            }
        
        else{
            string referenceText = $"{_book} {_chapter}:{_verse}";
            return referenceText;
        }
    }
}
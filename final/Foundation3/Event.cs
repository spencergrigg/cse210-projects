public abstract class Event{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _type;
    private Address _address = new Address();

    public Event(string title, string description, string date, string time, Address address, string type){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public void DisplayStandard(){
        Console.WriteLine($"{_title}: {_description} {_time} {_address}");
    }

    public void DisplayFull(){
        DisplayStandard();
        DisplayInfo();        
    }

    public void DisplayShort(){
        Console.WriteLine($"{_type} {_title} {_date}");
    }

    public abstract void DisplayInfo();
}
public abstract class Event{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _type;
    private double _cost;
    private Address _address = new Address();

    public Event(string title, string description, string date, string time, Address address, string type, double cost){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
        _cost = cost;
    }

    public void DisplayStandard(){
        Console.WriteLine($"{_title}: {_description} located at {_address.GetAddress()} @ {_time}. Price per person will be ${_cost}.");
    }

    public void DisplayFull(){
        DisplayStandard();
        DisplayInfo();        
    }

    public void DisplayShort(){
        Console.WriteLine($"{_type}: {_title} {_date} @ {_cost}/person");
    }

    public abstract void DisplayInfo();
}
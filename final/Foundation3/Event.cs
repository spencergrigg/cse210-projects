public abstract class Event{
    private string _title;
    private string _description;
    private int _date;
    private int _time;
    private Address _address = new Address();

    public Event(string title, string description, int date, int time, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual void DisplayStandard(){
        Console.WriteLine($"{_title}: {_description} {_time} {_address}");
    }

    public virtual void DisplayFull(){
        Console.WriteLine($"{_title}: {_description} {_time} {_address}");        
        //Lectures - name & capacity
        //Receptions - RSVP email
        //Gatherings - Weather statement
    }

    public virtual void DisplayShort(){
        Console.WriteLine($"{_title} {_date}");
        //Lists type, title and date
    }

}
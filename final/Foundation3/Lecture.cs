public class Lecture : Event{
            
    private string _speaker;
    private int _capacity;
        public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity, string type, double cost): base(title, description, date, time, address, type, cost){
            _speaker = speaker;
            _capacity = capacity;
    }

    public string GetSpeaker(){
        return _speaker;
    }

    public int GetCapacity(){
        return _capacity;
    }

    public override void DisplayInfo(){
        Console.WriteLine($"{_speaker} will be speaking and there are only {_capacity} seats, so buy your tickets now!");
    }
}
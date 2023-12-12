public class Gathering : Event{

    private string _weather;
        public Gathering(string title, string description, string date, string time, Address address, string weather, string type): base(title, description, date, time, address, type){
            _weather = weather;
    }

    public override void DisplayInfo(){
        Console.WriteLine($"The weather will be {_weather}. Dress appropriately!");
    }

}
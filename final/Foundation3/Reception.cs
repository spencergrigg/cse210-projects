public class Reception : Event{
    private string _rsvp;
        public Reception(string title, string description, string date, string time, Address address, string RSVP, string type, double cost): base(title, description, date, time, address, type, cost){
            _rsvp = RSVP;
    }

    public override void DisplayInfo(){
        Console.WriteLine($"Please RSVP to {_rsvp}. Better early than late!");
    }

}
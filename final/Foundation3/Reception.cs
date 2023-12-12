public class Reception : Event{
    private string _rsvp;
        public Reception(string title, string description, string date, string time, Address address, string RSVP, string type): base(title, description, date, time, address, type){
            _rsvp = RSVP;
    }

    public override void DisplayInfo(){
        Console.WriteLine($"Please RSVP to {_rsvp}. Better early than late!");
    }

}
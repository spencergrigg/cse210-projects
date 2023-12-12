using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to EventPlanningEasy");
        //Creates all subEvent objects
        Address address1 = new Address("2004 E AutumnBreeze St", "Boise", "Idaho", "USA");
        Address address2 = new Address("2023 W WinterFreeze Ave", "Cardston", "Alberta", "Canada");
        Address address3 = new Address("1234 Dusty Street St", "Salem", "Oregon", "USA");
        Reception reception1 = new Reception("Lara's Reception", "This is the description of the reception", "11/12/23", "1:00 PM", address1, "hello123@gmail.com", "Reception" );
        Lecture lecture1 = new Lecture("How the Brain Works", "Lecture will occur in the TeddyX center", "1/1/2011", "12:30", address2, "Jordan Pete", 200, "Lecture" );
        Gathering gathering1 = new Gathering("Field Trip", "KLD Second Grade Oregan Trail Field Trip", "2/2/2022", "9:00 AM Sharp", address3, "Sunny", "Gathering");
        
        //Creates list of Event objects
        List<Event> events = new List<Event>();
        events.Add(reception1);
        events.Add(lecture1);
        events.Add(gathering1);

        //Display Full Event
        foreach (Event item in events){
            item.DisplayFull();
            Console.WriteLine();
        }
Console.WriteLine("-------------------------------------------------");

        //Display Standard Event
        foreach (Event item in events){
            item.DisplayStandard();
        }
Console.WriteLine("-------------------------------------------------");

        //Display Short Event
        foreach (Event item in events){
            item.DisplayShort();
        }
Console.WriteLine("-------------------------------------------------");
    }
}
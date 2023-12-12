using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to EventPlanningEasy. Here's a list of upcoming events:");
        //Creates all subEvent objects
        Address address1 = new Address("2004 E AutumnBreeze St", "Boise", "Idaho", "USA");
        Address address2 = new Address("2023 W WinterFreeze Ave", "Cardston", "Alberta", "Canada");
        Address address3 = new Address("1234 Dusty Street St", "Salem", "Oregon", "USA");
        Reception reception1 = new Reception("Lara's Reception", "This is the description of the reception", "11/12/23", "1:00 PM", address1, "hello123@gmail.com", "Reception", 15.00 );
        Lecture lecture1 = new Lecture("How the Brain Works", "Lecture will occur in the TeddyX center", "1/1/2011", "12:30", address2, "Jordan Pete", 200, "Lecture", 50.00 );
        Gathering gathering1 = new Gathering("Field Trip", "KLD Second Grade Oregan Trail Field Trip", "2/2/2022", "9:00 AM Sharp", address3, "Sunny", "Gathering", 10.99);
        
        //Creates list of Event objects
        List<Event> events = new List<Event>();
        events.Add(reception1);
        events.Add(lecture1);
        events.Add(gathering1);


        //Display Full Event
        Console.WriteLine("-----Full Event Details-----");
        foreach (Event item in events){
            item.DisplayFull();
            Console.WriteLine();
        }
Console.WriteLine("-------------------------------------------------");

        //Display Standard Event
        Console.WriteLine("-----Standard Event Details-----");
        foreach (Event item in events){
            item.DisplayStandard();
            Console.WriteLine();
        }
Console.WriteLine("-------------------------------------------------");

        //Display Short Event
        Console.WriteLine("-----Brief Event Details-----");
        foreach (Event item in events){
            item.DisplayShort();
        }
Console.WriteLine("-------------------------------------------------");
    }
}
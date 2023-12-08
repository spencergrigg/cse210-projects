using System;

class Program
{
    static void Main(string[] args)
    {
        //Clears Console
        Console.Clear();

        //Video Objects
        List<Video> _videos = new List<Video>();
        Video video1 = new Video("Look at this shiny new video!", "Spencer", 25);
        Video video2 = new Video("Hello World", "Mary Jane", 25);
        Video video3 = new Video("The Blackthorne Key", "Rowan James Fenharrow", 2509);

        //Puts videos in a list
        List<Video> videosList = new List<Video>();
        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        //Comment Objects for Video1
        Comment comment1 = new Comment("DarkSpark123", "This is a great video!");
        Comment comment2 = new Comment("DSpark", "This is a great video!");
        Comment comment3 = new Comment("DS3", "This is a great video!");
        //Add Comment Objects to a list in the Video Object
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment1);
        
        //Comment Objects for Video2
        Comment comment4 = new Comment("Maverick", "Awesome!");
        Comment comment5 = new Comment("John Dear", "Sweet!");
        Comment comment6 = new Comment("Bob Doe", "Nice Job!");
        //Add Comment Objects to a list in the Video2 Object
        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);

        //Comment Objects for Video3
        Comment comment7 = new Comment("Flint Lockwood", "Looking Good!");
        Comment comment8 = new Comment("Matthew Meese", "This is quality material!");
        Comment comment9 = new Comment("The Messenger", "Hilarious!");
        //Add Comment Objects to a list in the Video Object
        video3._comments.Add(comment4);
        video3._comments.Add(comment5);
        video3._comments.Add(comment6);

        //Program to Display Output
        //For each loop written to iterate through videos
        Console.WriteLine("Welcome to the Video Tracker. Here are the stats:");
        foreach (Video item in videosList)
        {
            item.DisplayVideoInfo();
        }
    }
}
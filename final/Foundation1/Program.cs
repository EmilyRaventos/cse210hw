using System;
using System.Collections;

class Program
{
    static List<Video> _listOfVideos;
    static void Main(string[] args)
    {   
        List<Video> listOfVideos = new List<Video>();
        _listOfVideos = listOfVideos;

        Video v1 = new Video("Dune Trailer", "Denis Villeneuve", 208);
        Video v2 = new Video("Avatar Trailer", "James Cameron", 149);
        Video v3 = new Video("Pride and Prejudice Trailer", "Joe Wright", 161);
        Video v4 = new Video("Captain America: The First Avenger Trailer", "Joe Johnston", 145);

        Comment c1 = new Comment("Jane Doe", "I did not read the book and I did not know what to expect exactly. I LOVED it.");
        Comment c2 = new Comment("Johnny Smith", "This is an all-time great science fiction movie");
        Comment c3 = new Comment("Bill Johnson", "A slow burner, it's not Star Wars or Lord of the Rings, but epic in all proportions.");
        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);

        Comment c4 = new Comment("Emily Christofferson", "Very well made movie. The plot and storyline were epic, the visuals were stunning, and the music was also very majestic.");
        Comment c5 = new Comment("Bob Paul", "The most overrated film in history");
        Comment c6 = new Comment("Paul Richardson", " Visual Effects makes this movie so powerful that every creature and big scenery scenes looks real.");
        v2.AddComment(c4);
        v2.AddComment(c5);
        v2.AddComment(c6);

        Comment c7 = new Comment("Edward Stevenson", "A timeless adaptation of a timeless Jane Austen novel.");
        Comment c8 = new Comment("Sammi Hansen", "Wonderful Moments, Both Big and Small");
        Comment c9 = new Comment("Eliza Wood", "There's really nothing negative to say about the film. The actors are perfectly cast, the direction is subtle and well-realized, and even a shade more cinematic than I would have expected, or than it needed to be.");
        Comment c10 = new Comment("Chris Freeman", "This looks so good!");
        v3.AddComment(c7);
        v3.AddComment(c8);
        v3.AddComment(c9);
        v3.AddComment(c10);

        Comment c11 = new Comment("Kristen Thomas", "It's a good, action packed film.");
        Comment c12 = new Comment("Nick Random", "The story itself was fine, and I'm personally a big fan of Captain America's origin story so this movie was a nice watch for me. Maybe not so much if you don't care at all about superheroes.");
        Comment c13 = new Comment("Lindsey Macey", "A weak man knows the value of strength.");
        v4.AddComment(c11);
        v4.AddComment(c12);
        v4.AddComment(c13);

        _listOfVideos.Add(v1);
        _listOfVideos.Add(v2);
        _listOfVideos.Add(v3);
        _listOfVideos.Add(v4);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("========================================================================================");
        Console.WriteLine("                                     Foundation 1                                       ");
        Console.WriteLine("========================================================================================\n");
        Console.ResetColor();

        DisplayVideoInfo();
    }

    static void DisplayVideoInfo()
    {
        foreach (Video video in _listOfVideos)
        {
            video.DisplayInformation();
        }
    }
}
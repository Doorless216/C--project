using System;

public class Song
{
    public string Artist { get; set; }
    public string Title { get; set; }
    public TimeSpan Duration { get; set; }

    //constructor
    public Song(string title, string artist, TimeSpan duration)
    {
        Artist = artist;
        Title = title;
        Duration = duration;
    }
}
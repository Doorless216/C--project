using System;

public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public double Length { get; set; }

    public Song(string title, string artist, double length)
    {
        Title = title;
        Artist = artist;
        Length = length;
    }
    public void Display()
    {
        Console.WriteLine(Title + " by " + Artist + " duration " + Length);
        Console.WriteLine("SONG ADDED");


    }


}
using System;

public class Playlist
{
    private List<Song> songs = new List<Song>();
    public void AddSong(Song song)
    {
        songs.Add(song);
        Console.WriteLine("Song Added!" + song.Title);
    }
    public void RemoveSong(string title)
    {
        Song songToRemove = songs.Find(s => string.Equals(s.Title, title, StringComparison.OrdinalIgnoreCase));
        if (songToRemove != null)
        {
            songs.Remove(songToRemove);
            Console.WriteLine("Removed -" + songToRemove.Title);
        }
        else
        {
            Console.WriteLine("Song not found!");
        }
    }

    public void ShowSongs()
    {
        if (songs.Count == 0)
        {
            Console.WriteLine("Playlist is empty!");
            return;
        }
        foreach (Song song in songs)
        {
            Console.WriteLine(song.Title + " By " + song.Artist + " " + song.Duration);
        }


    }
}
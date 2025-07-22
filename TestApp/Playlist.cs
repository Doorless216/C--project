using System.Collections.Generic;

public class Playlist
{
    public List<Song> songs = new List<Song>();

    public void addSong(Song song)
    {
        songs.Add(song);
        Console.WriteLine("SONG ADDED");
    }
    public void viewSongs()
    {
        if (songs.Count == 0)
        {
            Console.WriteLine("Playlist Empty");
            return;
        }

        Console.WriteLine("\n --- Your Playlist --- ");
        foreach (Song song in songs)
        {
            song.Display();
        }
    }
}
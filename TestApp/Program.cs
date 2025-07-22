using System;
public class Program
{
    public static void Main(string[] args)
    {

        Playlist myPlaylist = new Playlist();

        while (true)
        {
            Console.WriteLine("Running- \nWelcome to thee Music Playlist");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Enter '1' to create a playlist");
            Console.WriteLine("Enter '2' to add a song");
            Console.WriteLine("Enter '3' to view playlist");
            Console.WriteLine("Enter '4' to exit");

            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Playlist Created!");
            }
            else if (input == 2)
            {
                Console.WriteLine("Enter the Title of the song: ");
                string title = Console.ReadLine();

                Console.WriteLine("Enter the Artist: ");
                string artist = Console.ReadLine();

                Console.WriteLine("Enter the length of the song: ");
                double length = double.Parse(Console.ReadLine());

                Song newSong = new Song(title, artist, length);
                myPlaylist.addSong(newSong);

            }
            else if (input == 3)
            {
                myPlaylist.viewSongs();

            }
            else if (input == 4)
            {
                break;
            }
        }
    }
}


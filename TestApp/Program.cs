using System;
using System.Diagnostics;
using System.Linq.Expressions;

public class Program
{
    public static void Main(string[] args)
    {
        //start stopwatch
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Playlist playlist = new Playlist();
        bool running = true;

        //main menu
        while (running)
        {
            while (running)
            {
                Console.WriteLine("\n Playlist Menu");
                Console.WriteLine("1. Add Song");
                Console.WriteLine("2. Remove Song");
                Console.WriteLine("3. Show Playlist");
                Console.WriteLine("4. Show Total Duration");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option (1-5): ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter song title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter the artist: ");
                        string artist = Console.ReadLine();

                        Console.Write("Enter the duration of the song(mm:ss): ");
                        string durationInput = Console.ReadLine();
                        TimeSpan duration;
                        if (TimeSpan.TryParse("00:" + durationInput, out duration))
                        {
                            Song newSong = new Song(title, artist, duration);
                            playlist.AddSong(newSong);
                        }
                        break;

                    case "2":
                        Console.Write("Enter title of the song you want removed: ");
                        string removeSong = Console.ReadLine();
                        playlist.RemoveSong(removeSong);
                        break;

                    case "3":
                        playlist.ShowSongs();
                        break;

                    case "4":
                        Console.WriteLine("Feature not added yet");
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting Program");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please enter 1-5");
                        break; 
                }
            }


            //stop stopwatch
            stopwatch.Stop();
            Console.WriteLine("Elapsed time for progam: " + stopwatch.Elapsed.TotalSeconds + "cSecoonds");
        }


    }
}

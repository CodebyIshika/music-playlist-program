using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs playlistObj = new Songs();

            while (true)
            {
                try
                {
                    Console.WriteLine("Choose an option: ");
                    Console.WriteLine("1. Add a song to your playlist.");
                    Console.WriteLine("2. Play the next song in your playlist.");
                    Console.WriteLine("3. Skip the next song.");
                    Console.WriteLine("4. Rewind one song.");
                    Console.WriteLine("5. Exit");

                    Console.Write("Write your choice(1, 2, 3, 4, 5): ");
                    int userChoice = int.Parse(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1:
                            Console.Write("Enter the song name: ");
                            string songName = Console.ReadLine();
                            playlistObj.AddSong(songName);
                            break;

                        case 2:
                            playlistObj.PlayNextSong();
                            break;


                        case 3:
                            playlistObj.SkipSong();
                            break;

                        case 4:
                            playlistObj.RewindSong();
                            break;

                        case 5:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

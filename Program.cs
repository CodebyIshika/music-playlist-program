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
                    Console.WriteLine("");
                    Console.WriteLine(" ---------------------------------------- ");
                    Console.WriteLine("|          Choose an option:             |");
                    Console.WriteLine(" ---------------------------------------- ");
                    Console.WriteLine("  1. Add a song to your playlist.");
                    Console.WriteLine(" ----------------------------------------");
                    Console.WriteLine("  2. Play the next song in your playlist.");
                    Console.WriteLine(" ----------------------------------------");
                    Console.WriteLine("  3. Skip the next song.");
                    Console.WriteLine(" ----------------------------------------");
                    Console.WriteLine("  4. Rewind one song.");
                    Console.WriteLine(" ---------------------------------------");
                    Console.WriteLine("  5. Exit");
                    Console.WriteLine(" ---------------------------------------");

                    Console.WriteLine("\n");
                    Console.Write("Enter your choice(1, 2, 3, 4, 5): ");
                    int userChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    switch (userChoice)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Enter the song name: ");
                            string songName = Console.ReadLine();
                            Console.WriteLine("");
                            playlistObj.AddSong(songName);
                            break;

                        case 2:
                            Console.Clear();
                            playlistObj.PlayNextSong();
                            break;


                        case 3:
                            Console.Clear();
                            playlistObj.SkipSong();
                            break;

                        case 4:
                            Console.Clear();
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
                catch (FormatException)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error: Please enter a valid choice.");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

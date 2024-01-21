using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05
{
    internal class Songs
    {
        Queue<string> songsQueue = new Queue<string>();
        Stack<string> songsStack = new Stack<string>();

        public void AddSong(string songName)
        {
            try
            {
                songsQueue.Enqueue(songName);
                Console.Clear();
                Console.WriteLine($"'{songName}' is added to your playlist.");
                Console.WriteLine("");
                DisplayNextSong();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Error in adding song : {ex.Message}");
            }

        }

        public void PlayNextSong()
        {
            try
            {
                Console.Clear();
                if (songsQueue.Count == 0)
                {
                    Console.WriteLine("Your Playlist is empty. Please add songs to your playlist.");
                }

                string currentSong = songsQueue.Dequeue();
                songsStack.Push(currentSong);
                Console.WriteLine($"Now playing : {currentSong}");
                Console.WriteLine("");
                DisplayNextSong();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Error in playing next song: {ex.Message}");
            }
        }

        public void SkipSong()
        {
            try
            {
                Console.Clear();
                if (songsQueue.Count == 0)
                {
                    Console.WriteLine("Your Playlist is empty. Please add songs to your playlist.");
                }

                string skippedSong = songsQueue.Dequeue();
                Console.WriteLine($"Skipped : {skippedSong}");

            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Error in skipping the next song: {ex.Message}");
            }
        }

        public void RewindSong()
        {
            try
            {
                Console.Clear();
                if (songsStack.Count == 0)
                {
                    Console.WriteLine("Sorry, there is no previous song to rewind.");
                    return;
                }

                string previousSong = songsStack.Pop();
                songsQueue.Enqueue(previousSong);
                Console.WriteLine($"Rewinding to {previousSong}");
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Error in rewinding the song: {ex.Message}");
            }
        }

        public void DisplayNextSong()
        {
            Console.WriteLine($"Next song: {songsQueue.Peek()}");
        }
    }
}

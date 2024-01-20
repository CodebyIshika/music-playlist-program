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
            songsQueue.Enqueue(songName);
            Console.WriteLine($"{songName} is added to your playlist.");
        }

        public void PlayNextSong()
        {
            if ( songsQueue.Count == 0 )
            {
                Console.WriteLine("Your Playlist is empty. Please add songs to your playlist.");
            }

            string currentSong = songsQueue.Dequeue();
            songsStack.Push(currentSong);
            Console.WriteLine($"Now playing : {currentSong}");
        }

        public void SkippedSong()
        {
            if (songsQueue.Count == 0)
            {
                Console.WriteLine("Your Playlist is empty. Please add songs to your playlist.");
            }

            string skippedSong = songsQueue.Dequeue();
            Console.WriteLine($"Skipped : {skippedSong}");
        }

        public void RewindSong()
        {
            if( songsStack.Count == 0 )
            {
                Console.WriteLine("Sorry, there is no previous song to rewind.");
                return;
            }

            string previousSong = songsStack.Pop();
            songsQueue.Enqueue(previousSong);
            Console.WriteLine($"Rewinding to {previousSong}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab_05
{
    internal class Songs
    {
        Queue<string> songsQueue = new Queue<string>();
        Stack<string> songsStack = new Stack<string>();

        /// <summary>
        /// This method checks  the validity of song name and make it doesn't have
        /// any special character.
        /// </summary>
        /// <param name="songName"></param>
        /// <returns></returns>
        public bool isSongNameValid(string songName)
        {
            // regex for song name
            string pattern = @"^[A-Za-z0-9\s]*$";
            if (!Regex.IsMatch(songName, pattern))
            {
                Console.WriteLine("Invalid song name. Please enter a valid song.");
                return false;
            }
            return true;
        }


        /// <summary>
        /// This method adds a song to the playlist.If the song name 
        /// is valid, it is added to the playlist, and a success 
        /// message is displayed, including the name of the added song. 
        /// </summary>
        /// <param name="songName"></param>
        public void AddSong(string songName)
        {
            try
            {
                // check the validity of song name
                if (isSongNameValid(songName))
                {
                    // add the song to the playlist
                    songsQueue.Enqueue(songName);
                    Console.WriteLine($"'{songName}' is added to your playlist.");
                    Console.WriteLine("");

                    // display the next song in the playlist
                    DisplayNextSong();
                    Console.WriteLine("");
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Error in adding song : {ex.Message}");
            }
        }


        /// <summary>
        /// This method plays the next song of the playlist.
        /// </summary>
        public void PlayNextSong()
        {
            try
            {
                // checks if the playlist is empty or not
                if (songsQueue.Count == 0)
                {
                    Console.WriteLine("Your Playlist is empty. Please add songs to your playlist.");
                }

                // remove the next song fromthe playlist
                string currentSong = songsQueue.Dequeue();

                // add the removed song onto the stack
                songsStack.Push(currentSong);

                // Display the currently playing song
                Console.WriteLine($"Now playing : {currentSong}");
                Console.WriteLine("");

                // Display the next song in the playlist
                DisplayNextSong();
            }
            catch 
            {
                Console.Clear();
                Console.WriteLine($"Error: No song availabe to play next.");
            }
        }


        /// <summary>
        /// This method skips the next song of the playlist.
        /// </summary>
        public void SkipSong()
        {
            try
            {
                // Check if the playlist is empty
                if (songsQueue.Count == 0)
                {
                    Console.WriteLine("Your Playlist is empty. Please add songs to your playlist.");
                }

                // Remove the next song and display it as skipped
                string skippedSong = songsQueue.Dequeue();
                Console.WriteLine($"Skipped : {skippedSong}");

            }
            catch 
            {
                Console.Clear();
                Console.WriteLine($"Error: There is no song available to skip in your playlist.");
            }
        }


        /// <summary>
        /// Rewind to the previous song of the playlist
        /// </summary>
        public void RewindSong()
        {
            try
            {
                // check if there is a previous song in the playlist
                if (songsStack.Count == 0)
                {
                    Console.WriteLine("Sorry, there is no previous song to rewind.");
                    return;
                }

                string previousSong = songsStack.Pop();
                songsQueue.Enqueue(previousSong);
                Console.WriteLine($"Rewinding to '{previousSong}'");
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Error in rewinding the song: {ex.Message}");
            }
        }

        
        /// <summary>
        /// This method displays the next song of the playlist
        /// </summary>
        public void DisplayNextSong()
        {
            if (songsQueue.Count > 0)
            {
                Console.WriteLine($"Next song: {songsQueue.Peek()}");
            }
            else
            {
                Console.WriteLine("No upcoming songs in your playlist.");
            }
        }
    }
}

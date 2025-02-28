using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    interface IPlayable
    {
        void Play(); // Method to be implemented by classes
    }

    // Implementing interface in MusicPlayer
    class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music...");
        }
    }

    // Implementing interface in VideoPlayer
    class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video...");
        }
    }

    //class Program8
    //{
    //    static void Main()
    //    {
    //        IPlayable player;

    //        // Using MusicPlayer
    //        player = new MusicPlayer();
    //        player.Play(); // Calls Play() from MusicPlayer

    //        // Using VideoPlayer
    //        player = new VideoPlayer();
    //        player.Play(); // Calls Play() from VideoPlayer
    //    }
    //}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPexample
{
    interface IMusicService
    {
        void Playsong(string song);
    }

    class SpotifyService : IMusicService
    {
        public void Playsong(string song) { Console.WriteLine($"play {song} from spotify."); }
    }
        class YouTubeService : IMusicService
        {
            public void Playsong(string song) { Console.WriteLine($"play {song} from youtube."); }
        }

        class JioSaavan : IMusicService
        {
            public void Playsong(string song) { Console.WriteLine($"play {song} from jiosaavan."); }
        }
        class MusicApp
        {
            private IMusicService musicService;

            public MusicApp(IMusicService _musicService)
            {
                musicService = _musicService;
            }


            public void Playsong(string song) { musicService.Playsong(song); }
        }
        class Program
        {
            static void Main(string[] args)
            {
                //using spotify service
                IMusicService spotify = new SpotifyService();
                MusicApp app = new MusicApp(spotify);
                app.Playsong("Ishq hai...");

                //using youtube service 
                IMusicService youtube = new YouTubeService();
                MusicApp app1 = new MusicApp(youtube);
                app1.Playsong("Skyfall...");

                //using jiosaavan service
                IMusicService jio = new JioSaavan();
                MusicApp app2 = new MusicApp(jio);
                app2.Playsong("vaage Vaage...");

                Console.ReadKey();
            }
        }
    }


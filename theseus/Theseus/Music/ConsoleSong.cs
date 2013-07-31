using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Theseus.Music
{
    public class ConsoleSong: ISong
    {
        private String song;
        private Thread t;

        public ConsoleSong(String path)
        {
            t = null;
            StreamReader sr = new StreamReader(path);
            song = sr.ReadLine();


        }

        public void play()
        {
            if (t == null)
            {

                t = new Thread(() => Tones.PlaySong(song));
                t.Start();
            }       

         }

        public void stop()
        {
            t.Abort();
            t = null;
        }
    }
}

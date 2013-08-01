using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Serialization;

namespace Theseus.Music
{
    [Serializable]
    public class WavSong : ISong
    {
        private String path;
        [NonSerialized]
        private Thread t;

        public WavSong(String path)
        {
            t = null;
            this.path = path;
        }

        public void play()
        {
            if (t == null)
            {
                 t = new Thread(() => Songs.playWav(path));
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

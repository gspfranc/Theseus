﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Theseus.Music
{
    public class WavSong : ISong
    {
        private String path;
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
                 t = new Thread(() => playWav(path));
                t.Start();
            }

        }

        public void stop()
        {
            t.Abort();
            t = null;
        }

        public static void playWav(String path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = path;
            player.PlayLooping();
        }
    }
}

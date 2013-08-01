using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Theseus.Music
{
    /// <summary>
    /// Implémentation d'une chanson console.
    /// Utilise les sons de la console pour faire jouer une mélodie.
    /// (Emprunt à l'internet :), voir Beep.cs pour source.)
    /// </summary>
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

        /// <summary>
        /// Démmare la chanson dans un autre thread.
        /// </summary>
        public void play()
        {
            if (t == null)
            {
                t = new Thread(() => Tones.PlaySong(song));
                t.Start();
            }       
         }

        /// <summary>
        /// Tue le thread pour arrêter la chanson.
        /// Pas très propre, mais très efficace.
        /// </summary>
        public void stop()
        {
            t.Abort();
            t = null;
        }
    }
}

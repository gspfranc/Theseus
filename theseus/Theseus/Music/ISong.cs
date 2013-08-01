using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus.Music
{
    /// <summary>
    /// Interface d'une chanson. On peut commencer à faire jouer une chanson ou l'arrêter.
    /// </summary>
    public interface ISong
    {
        void play();
        void stop();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    /// <summary>
    /// Interface définissant l'état d'un état de jeu.
    /// </summary>
    public interface IGameState
    {
        bool isRunning();
        bool isVictory();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    /// <summary>
    /// Interface pour un message à envoyer à un maze.
    /// </summary>
    public interface MazeMessage
    {
        void DoAction(Maze m);
    }
}

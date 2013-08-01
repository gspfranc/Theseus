using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    /// <summary>
    /// Défini un observer de type Maze
    /// </summary>
    public interface IMazeObserver
    {
        void SendMessage(MazeMessage message);
    }
}

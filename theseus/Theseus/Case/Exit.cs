using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;

namespace Theseus.Case
{
    /// <summary>
    /// Case de sortie du maze. Lorsque cette case est atteinte, le maze
    /// contenant cette case est averti.
    /// </summary>
    [Serializable()]
    public abstract class Exit : ACase
    {
        IMazeObserver mazeObserver;
        protected Exit(Maze m)
        {
            mazeObserver = m;
        }

        public override void MoveIn(ADude p)
        {
            mazeObserver.SendMessage(new MazeMessageChangeState(new GameStateWin()));
        }
    }
}

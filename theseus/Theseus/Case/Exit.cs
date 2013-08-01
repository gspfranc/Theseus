using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;

namespace Theseus.Case
{
    [Serializable()]
    public abstract class Exit : ACase
    {
        Maze mazeObserver;
        protected Exit(Maze m)
        {
            mazeObserver = m;
        }

        public override void MoveIn(ADude p)
        {
            mazeObserver.NotifyGameStateChanged(new WinGameState());
        }
    }
}

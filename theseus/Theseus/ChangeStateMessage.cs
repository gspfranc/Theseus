using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    public class ChangeStateMessage : MazeMessage
    {
        private IGameState gs;

        public ChangeStateMessage(IGameState gs)
        {
            this.gs = gs;
        }

        public void DoAction(Maze m)
        {
            m.SetGameState(gs);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    /// <summary>
    /// Message envoyé par un observee au maze pour changer son état d'exécution.
    /// </summary>
    public class MazeMessageChangeState : MazeMessage
    {
        private IGameState gs;

        public MazeMessageChangeState(IGameState gs)
        {
            this.gs = gs;
        }

        public void DoAction(Maze m)
        {
            m.SetGameState(gs);
        }
    }
}

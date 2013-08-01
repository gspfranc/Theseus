using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    public class WinGameState : IGameState
    {
        public bool isRunning()
        {
            return false;
        }

        public bool isVictory()
        {
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    [Serializable]
    public class GameStateRunning : IGameState
    {
        public bool isRunning()
        {
            return true;
        }

        public bool isVictory()
        {
            return false;
        }
    }
}

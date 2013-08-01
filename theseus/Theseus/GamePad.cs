using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    /// <summary>
    /// Servirait au multiplayer ou au changement de configuration des touches.
    /// Défini quelles clés correspondent avec quelle action.
    /// </summary>
    public class GamePad
    {
        public GamePad(ConsoleKey up, ConsoleKey down, ConsoleKey left, ConsoleKey right)
        {
            this.up = up;
            this.down = down;
            this.left = left;
            this.right = right;
        }

        public ConsoleKey up { get; private set; }
        public ConsoleKey down { get; private set; }
        public ConsoleKey left { get; private set; }
        public ConsoleKey right { get; private set; }
    }
}

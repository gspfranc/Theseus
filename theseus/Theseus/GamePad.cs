using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    public class GamePad
    {
        public GamePad()
        {
            this.up = ConsoleKey.UpArrow;
            this.down = ConsoleKey.DownArrow;
            this.left = ConsoleKey.LeftArrow;
            this.right = ConsoleKey.RightArrow;
        }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    public class Player : ADude
    {
        public Player(GamePad gp)
        {
            gamePad = gp;
        }
        int health { get; set; }
        public GamePad gamePad { get; private set; }

        public override void Draw()
        {
            Console.Write('P');
        }
    }
}

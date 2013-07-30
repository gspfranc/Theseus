using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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

        public override void Draw(StringWriter s)
        {
            s.Write('P');
        }
    }
}

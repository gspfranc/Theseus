using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Theseus
{
    [Serializable()]
    public class Player : ADude
    {
        public Player(GamePad gp, IMazeObserver observer)
            : base(100, observer)
        {
            gamePad = gp;
        }        

        public GamePad gamePad { get; private set; }

        public override void Draw(IGameEngine s)
        {
            s.Draw(Coord, 'P');
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theseus.Case
{
    public abstract class Trap : ACase
    {
        public override void MoveIn(ADude p)
        {
            //player.dodammage(15);
            p.Coord = Coord;
        }
    }
}

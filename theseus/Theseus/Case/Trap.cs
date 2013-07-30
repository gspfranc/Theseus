using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theseus.Case
{
    [Serializable()]
    public abstract class Trap : ACase
    {
        public override void MoveIn(IDude p)
        {
            //player.dodammage();
            p.Coord = Coord;
        }
    }
}

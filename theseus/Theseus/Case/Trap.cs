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
        public override void MoveIn(ADude p)
        {
            p.ReceiveDammage(50);
            p.Coord = Coord;
        }
    }
}

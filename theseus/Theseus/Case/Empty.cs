using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theseus.Case
{
    public abstract class Empty : ACase
    {
        public override void MoveIn(ADude p)
        {
            p.Coord = Coord;
        }
    }
}

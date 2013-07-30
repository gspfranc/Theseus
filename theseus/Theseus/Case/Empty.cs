using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;

namespace Theseus.Case
{
    [Serializable()]
    public abstract class Empty : ACase
    {
        public override void MoveIn(ADude p)
        {
            p.Coord = Coord;
        }
    }
}

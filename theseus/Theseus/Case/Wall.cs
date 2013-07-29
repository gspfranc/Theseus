using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theseus.Case
{
    public abstract class Wall : ACase
    {
        public override void MoveIn(IDude p)
        {
            // Cannot move into a wall
        }
    }
}

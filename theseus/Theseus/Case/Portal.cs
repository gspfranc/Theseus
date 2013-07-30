﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus.Case
{
    [Serializable()]
    public abstract class Portal : ACase
    {
        public override void MoveIn(IDude p)
        {
            p.Coord = Coord;
        }
    }
}

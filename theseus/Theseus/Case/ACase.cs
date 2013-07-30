using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Theseus.Case
{
    public abstract class ACase : IDrawable
    {
        public Point Coord { get; set; }
        public abstract void MoveIn(ADude p);

        public abstract void Draw();
        public virtual bool IsPlayerSpawn()
        {
            return false;
        }
    }
}

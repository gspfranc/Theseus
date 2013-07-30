using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace Theseus.Case
{
    [Serializable()]
    public abstract class ACase : IDrawable
    {
        public Point Coord { get; set; }
        public abstract void MoveIn(IDude p);

        public abstract void Draw(StringWriter s);
    }
}

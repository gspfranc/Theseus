using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Theseus
{
    interface IDude : IDrawable
    {
        public Point Coord { get; set; }
    }
}

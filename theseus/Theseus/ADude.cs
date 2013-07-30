using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Theseus
{
    public abstract class ADude : IDrawable
    {
        public Point Coord { get; set; }
        
        public abstract void Draw();
    }
}
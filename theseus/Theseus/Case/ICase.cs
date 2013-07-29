using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Theseus.Case
{
    public interface ICase : IDrawable
    {
        Point Coord { get; set; }
        void MoveIn(IDude p);
    }
}

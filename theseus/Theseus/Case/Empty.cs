using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theseus.Case
{
   public class Empty : ICase
    {
        public void Draw()
        {
            throw new NotImplementedException();
        }

        public Point Coord { get; set; }
        public void MoveIn(IDude p)
        {
            p.Coord = Coord;
        }
    }
}

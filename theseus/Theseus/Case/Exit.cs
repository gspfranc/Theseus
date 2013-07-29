using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theseus.Case
{
   public class Exit : ICase  
    {
        public void Draw()
        {
            Console.Write('E');
        }

        public Point Coord { get; set; }
        public void MoveIn(IDude p)
        {
            p.Coord = Coord;
        }
    }
}

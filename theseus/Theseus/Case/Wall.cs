using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theseus.Case
{
   public class Wall : ICase
    {
        public void Draw()
        {
            Console.Write('=');
        }

        public Point Coord { get; set; }

        public void MoveIn(IDude p)
        {
            // Cannot move into a wall
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Theseus.Case
{
    [Serializable()]
    public class DungeonExit : Exit
    {
        public DungeonExit(Maze m)
            : base(m)
        {}

        public override void Draw(IGameEngine s)
        {
            s.Draw(Coord, 'E');
        }
    }
}

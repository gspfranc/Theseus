using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Theseus.Case
{
    [Serializable()]
    public class DungeonEmpty : Empty
    {
        public override void Draw(IGameEngine s)
        {
            s.Draw(Coord, ' ');

        }
    }
}

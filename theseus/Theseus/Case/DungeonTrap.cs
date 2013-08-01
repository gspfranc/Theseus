using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Theseus.Case
{
    [Serializable()]
    public class DungeonTrap : Trap
    {
        public override void Draw(IGameEngine s)
        {
            s.Draw(Coord, 'X');
        }

        public override void DoDammage(ADude d)
        {
            d.ReceiveDammage(50);
        }
    }
}

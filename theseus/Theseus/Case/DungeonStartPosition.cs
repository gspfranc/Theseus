using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace Theseus.Case
{
    [Serializable()]
   public class DungeonStartPosition : StartPosition
   {
       public override bool IsPlayerSpawn() { return true; }
       public override void Draw(IGameEngine s)
       {
           s.Draw(Coord, '░', Color.Black, Color.Gray);
       }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus.Case
{
    public class DungeonExit : Exit
    {
        public override void Draw()
        {
            Console.Write('E');
        }
    }
}

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
        public override void Draw(StringWriter s)
        {
            s.Write('X');
        }
    }
}

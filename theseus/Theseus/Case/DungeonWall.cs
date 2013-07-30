﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Theseus.Case
{
    [Serializable()]
    public class DungeonWall : Wall
    {
        public override void Draw(StringWriter s)
        {
            s.Write('=');
        }
    }
}

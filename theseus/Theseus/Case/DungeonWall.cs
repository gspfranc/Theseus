﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace Theseus.Case
{
    [Serializable()]
    public class DungeonWall : Wall
    {
        public override void Draw(IGameEngine s)
        {
            s.Draw(Coord, '█',Color.DarkBlue,Color.White);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;

namespace Theseus.Case
{
    /// <summary>
    /// Case vide. Permet au joueur d'entrer dedans sans conséquence.
    /// </summary>
    [Serializable()]
    public abstract class Empty : ACase
    {
        public override void MoveIn(ADude p)
        {
            p.Coord = Coord;
        }
    }
}

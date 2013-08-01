using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theseus.Case
{
    /// <summary>
    /// Représente un mur. Personne ne peut entrer dans un mur.
    /// </summary>
    [Serializable()]
    public abstract class Wall : ACase
    {
        public override void MoveIn(ADude p)
        {
            // Cannot move into a wall
        }
    }
}

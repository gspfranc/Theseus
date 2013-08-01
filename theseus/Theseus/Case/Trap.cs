using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theseus.Case
{
    /// <summary>
    /// Enlève de la vie au personnage et bouge le personnage à l'emplacement du piège.
    /// Template method pour le DoDammage.
    /// </summary>
    [Serializable()]
    public abstract class Trap : ACase
    {
        public override void MoveIn(ADude d)
        {
            DoDammage(d);
            d.Coord = Coord;
        }

        public abstract void DoDammage(ADude d);
    }
}

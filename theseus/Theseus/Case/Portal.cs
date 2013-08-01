using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus.Case
{
    /// <summary>
    /// Classe pas encore implémentée.
    /// Elle était supposée téléporter le joueur dans une autre case.
    /// </summary>
    [Serializable()]
    public abstract class Portal : ACase
    {
        public override void MoveIn(ADude p)
        {
            //Not yet implemented
            p.Coord = Coord;
        }
    }
}

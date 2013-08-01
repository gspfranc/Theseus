using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus.Case
{
    /// <summary>
    /// Défini un endroit où le joueur peut spawner.
    /// </summary>
    [Serializable()]
    public abstract class  StartPosition: Empty
    {
        public override bool IsPlayerSpawn() { return true; }
    }
}

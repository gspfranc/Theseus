using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    /// <summary>
    /// Message envoyé par un observee au maze pour tuer un joueur.
    /// </summary>
    public class MazeMessageKill : MazeMessage
    {
        private ADude dude;

        public MazeMessageKill(ADude dude)
        {
            this.dude = dude;
        }

        public void DoAction(Maze m)
        {
            m.RemoveDude(dude);
        }
    }
}

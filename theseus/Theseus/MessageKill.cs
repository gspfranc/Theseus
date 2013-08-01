using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    public class MessageKill : MazeMessage
    {
        private ADude dude;

        public MessageKill(ADude dude)
        {
            this.dude = dude;
        }

        public void DoAction(Maze m)
        {
            m.RemoveDude(dude);
        }
    }
}

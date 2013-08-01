using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace Theseus
{
    [Serializable()]
    public abstract class ADude : IDrawable
    {
        public Point Coord { get; set; }
        int health { get; set; }
        private IMazeObserver observer;

        public ADude(int life, IMazeObserver observer)
        {
            health = life;
            this.observer = observer;
        }

        public void RecieveDammage(int dammage)
        {
            health -= dammage;
            if (health < 0)
                observer.SendMessage(new MessageKill(this));
        }

        public abstract void Draw(IGameEngine s);
    }
}
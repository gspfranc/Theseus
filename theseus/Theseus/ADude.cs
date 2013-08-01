using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace Theseus
{
    /// <summary>
    /// Un personnage possède une position dans le maze et un certain nombre de points de vie.
    /// Chaques types de personnages peut se dessiner à sa facon.
    /// </summary>
    [Serializable()]
    public abstract class ADude : IDrawable
    {
        public Point Coord { get; set; }
        public int health { get; set; }
        private IMazeObserver observer;

        public ADude(int life, IMazeObserver observer)
        {
            health = life;
            this.observer = observer;
        }

        /// <summary>
        /// Fonction servant à enlever des points de vie à un personnage.
        /// Observee observé par le maze contenant le player.
        /// </summary>
        /// <param name="dammage">nombre de points de vie à enlever</param>
        public void ReceiveDammage(int dammage)
        {
            health -= dammage;
            if (health <= 0)
                observer.SendMessage(new MazeMessageKill(this));
        }

        public abstract void Draw(IGameEngine s);
    }
}
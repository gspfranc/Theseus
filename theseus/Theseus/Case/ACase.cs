using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace Theseus.Case
{
    /// <summary>
    /// Classe abstraite pour les cases. N'est pas une interface afin
    /// de pouvoir contenir la proriété des coordonnées.
    /// </summary>
    [Serializable()]
    public abstract class ACase : IDrawable
    {
        /// <summary>
        /// Coordonnées en X et Y de la case dans le Maze.
        /// </summary>
        public Point Coord { get; set; }

        /// <summary>
        /// Chaque cases ont des conséquences différentes lorsqu'un personnage entre dedans.
        /// certaines enlèvent de la vie, d'autres déplace le personnage.
        /// </summary>
        /// <param name="p">Personnage entrant dans la case</param>
        public abstract void MoveIn(ADude p);

        /// <summary>
        /// Permet à chaque implémentation de la classe ACase de se dessiner de façon différente.
        /// </summary>
        /// <param name="s"></param>
        public abstract void Draw(IGameEngine s);


        /// <summary>
        /// Défini si la case en question est un emplacement valide pour Spawner un joueur.
        /// </summary>
        public virtual bool IsPlayerSpawn()
        {
            return false;
        }
    }
}

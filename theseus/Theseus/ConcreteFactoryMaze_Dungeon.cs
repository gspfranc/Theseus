using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Theseus.Case;

namespace Theseus
{
    /// <summary>
    /// Factory concrète d'un maze de type "Dungeon"
    /// </summary>
    class ConcreteFactoryMaze_Dungeon : AbstractFactoryMaze
    {
        public Empty CreateEmpty()
        {
            return new DungeonEmpty();
        }

        public Wall CreateWall()
        {
            return new DungeonWall();
        }

        public Trap CreateTrap()
        {
            return new DungeonTrap();
        }

        public Portal CreatePortal3()
        {
            return new DungeonPortal();
        }

        public Exit CreateExit(Maze maze)
        {
            return new DungeonExit(maze);
        }

        public Empty CreateStartPosition()
        {
            return new DungeonStartPosition();
        }
    }
}

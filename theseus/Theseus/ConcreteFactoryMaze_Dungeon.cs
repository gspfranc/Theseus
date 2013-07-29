using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Theseus.Case;

namespace Theseus
{
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

        public Exit CreateExit()
        {
            return new DungeonExit();
        }

        public Empty CreateStartPosition()
        {
            return new DungeonStartPosition();
        }
    }
}

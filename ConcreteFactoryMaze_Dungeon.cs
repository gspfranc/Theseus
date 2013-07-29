using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    class ConcreteFactoryMaze_Dungeon : AbstractFactoryMaze 
    {
        public ICase CreateEmpty()
        {
            throw new NotImplementedException();
        }

        public ICase CreateWall()
        {
            throw new NotImplementedException();
        }

        public ICase CreateTrap()
        {
            throw new NotImplementedException();
        }

        public ICase CreatePortal3()
        {
            throw new NotImplementedException();
        }
    }
}

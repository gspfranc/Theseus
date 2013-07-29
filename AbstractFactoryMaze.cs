using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    public interface AbstractFactoryMaze
    {
        // TODO: changer les types
        ICase CreateEmpty();

        ICase CreateWall();

        ICase CreateTrap();

        ICase CreatePortal3();
    }
}

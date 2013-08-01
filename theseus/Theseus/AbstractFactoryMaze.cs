using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Theseus;
using Theseus.Case;
namespace Theseus
{
    public interface AbstractFactoryMaze
    {
        Empty CreateEmpty();

        Wall CreateWall();

        Trap CreateTrap();

        Portal CreatePortal3();

        Exit CreateExit(Maze maze);

        Empty CreateStartPosition();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Theseus;
using Theseus.Case;
namespace Theseus
{
    /// <summary>
    /// Selon la factory abstraite, on créé les spécifications des arborescences du bon type.
    /// ex. dungeon, forest, futuristic, snow... (Seulement implémenté la factory concrète de dungeon)
    /// </summary>
    public interface AbstractFactoryMaze
    {
        Empty CreateEmpty();

        Wall CreateWall();

        Trap CreateTrap();

        Portal CreatePortal3();

        Exit CreateExit(Maze maze);

        Empty CreateStartPosition();

        //ADude CreateMonsterBasic();
        //ADude CreateMonsterMedium();
        //ADude CreateMonsterBoss();
    }
}

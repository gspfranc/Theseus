using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    /// <summary>
    /// Représente la partie Component du pattern Composite.
    /// IGame (Component), Maze (leaf) et MultiGame (composite).
    /// </summary>
    public interface IGame
    {
        //true == victory
        //false == loose, badly, you died... GAME OVER!
        bool Play();
    }
}

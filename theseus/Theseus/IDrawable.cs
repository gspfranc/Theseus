using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Theseus
{
    /// <summary>
    /// Interface forçant les sous-classes à implementer la fonction draw.
    /// Pattern Composite déformé : IDrawable (component), Maze (composite) et les cases (leafs)
    /// Ne respecte pas entièrement le pattern, mais est très semblable
    /// </summary>
    public interface IDrawable
    {
        void Draw(IGameEngine s);
    }
}

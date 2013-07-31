using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Theseus
{
    public interface IGameEngine
    {
        void Draw(Point coord, char c);
        void Draw(Point coord, char c, Color foreground, Color background);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Theseus
{
    public interface ICase : IDrawable
    {
        Point GetCoord();
        void MoveIn(IDude p);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    public interface IGame
    {
        //true == victory
        //false == loose, badly, you died... GAME OVER!
        bool Play();
    }
}

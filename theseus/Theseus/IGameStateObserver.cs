using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    public interface IGameStateObserver
    {
        void NotifyGameStateChanged(IGameState gameState);
    }
}

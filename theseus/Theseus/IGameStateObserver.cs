﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theseus
{
    public interface IMazeObserver
    {
        void SendMessage(MazeMessage message);
    }
}

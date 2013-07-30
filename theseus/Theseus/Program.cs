using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Theseus
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeReader mr = new MazeReader();
            Labyrinth maze = mr.CreateMaze(@"U:\dah.txt");
            maze.Draw();
        }
    }
}

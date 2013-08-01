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
            GamePad gp = new GamePad(ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow);
            mr.AddGamePad(gp);

            
            mr.CreateMazes("MazeFiles").Play();

            Console.ReadKey();
        }
    }
}

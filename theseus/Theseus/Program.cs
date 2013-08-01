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

            var sb = new StringBuilder();

            sb.AppendLine("dungeon");
            sb.AppendLine("9");
            sb.AppendLine("6");
           // sb.AppendLine("wav .\\Songs\\QuickSilver.wav");
            sb.AppendLine("console .\\Songs\\tetris.txt");
            sb.AppendLine("= = = = = =");
            sb.AppendLine("= P = = = =");
            sb.AppendLine("= o = E o =");
            sb.AppendLine("= o = = o =");
            sb.AppendLine("= o = = o =");
            sb.AppendLine("= o o o o =");
            sb.AppendLine("= o = = = =");
            sb.AppendLine("= o o o o =");
            sb.AppendLine("= = = = = =");

            var fileContent = sb.ToString();

            string fileName = "Start.txt";
            File.WriteAllText(fileName, fileContent);

            MultiGame mg = new MultiGame();
            mg.AddGame(mr.CreateMaze(fileName));
            mg.Play();
        }
    }
}

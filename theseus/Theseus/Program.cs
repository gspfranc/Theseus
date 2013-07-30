﻿using System;
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
            var sb = new StringBuilder();

            sb.AppendLine("dungeon");
            sb.AppendLine("9");
            sb.AppendLine("6");
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

            string fileName = "test.txt";
            File.WriteAllText(fileName, fileContent);
            MazeReader reader = new MazeReader();
            var labyrinth = reader.CreateMaze(fileName);

            Console.Write(labyrinth.ToString());
            
        }
    }
}

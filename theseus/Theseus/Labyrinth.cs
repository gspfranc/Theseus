using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theseus.Case;

namespace Theseus
{
    public class Labyrinth
    {
        private List<List<ACase>> grid = new List<List<ACase>>();
        public Labyrinth()
        { }

        public Labyrinth(List<List<ACase>> grid)
        {
            this.grid = grid;
            Validate();
        }

        public void Validate()
        {
            int height = grid.Count;

            if (height == 0)
                throw new Exception("Invalid labyrinth file, Labyrinth is empty");

            int width = grid[0].Count;
            foreach (var row in grid)
            {
                if (row.Count != width)
                    throw new Exception("Invalid labyrinth file, Labyrinth width not uniform.");
            }

            if (!grid.Any(row => row.Any(a=>a is DungeonStartPosition)))
                throw new Exception("Invalid labyrinth file, Labyrinth has no player start position");

            if (!grid.Any(row => row.Any(a => a is Exit)))
                throw new Exception("Invalid labyrinth file, Labyrinth has no exit marker");
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var row in grid)
            {
                foreach(var c in row)
                    sb.Append(c);
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public void Draw()
        {
            Console.Write(ToString());
        }

        public ACase this[int i, int j]
        {
            get { return grid[i][j]; }
            set { grid[i][j] = value; } 
        }
    }
}

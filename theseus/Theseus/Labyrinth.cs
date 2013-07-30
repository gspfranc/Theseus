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
    public class Labyrinth : IDrawable
    {
        private ACase[,] grid;
        public Labyrinth(int sizeX, int sizeY)
        {
            grid = new ACase[sizeX, sizeY];
        }

        public Labyrinth(List<List<ACase>> grid)
        {
            for (int i = 0; i != grid.Count; ++i)
            {
                for(int j=0; i!= grid[i].Count; ++j)
                    this.grid[i,j] = grid[i][j];
            }
            Validate();
        }

        public void Validate()
        {
            int height = grid.Length;

            if (height == 0)
                throw new Exception("Invalid labyrinth file, Labyrinth is empty");
            /*
            int width = grid.GetLength(0);
            for(int i=0; i != grid.;++i)
            {
                if (grid.GetLength(i) != width)
                    throw new Exception("Invalid labyrinth file, Labyrinth width not uniform.");
            }*/
            /*
            if (!grid.Any(row => row.Any(a=>a is DungeonStartPosition)))
                throw new Exception("Invalid labyrinth file, Labyrinth has no player start position");

            if (!grid.Any(row => row.Any(a => a is Exit)))
                throw new Exception("Invalid labyrinth file, Labyrinth has no exit marker");*/
        }
        /*
        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i != grid.GetLength(0); ++i)
            {
                for (int j = 0; i != grid.GetLength(1); ++j)
                {
                    sb.Append(grid[i, j].ToString());
                }
                sb.Append('\n');
                //Console.Write("\n");                  
            }

            return sb.ToString();
        }*/

        public void Draw()
        {
            for (int i = 0; i != grid.GetLength(0); ++i)
            {
                for (int j = 0; j != grid.GetLength(1); ++j)
                {
                    grid[i, j].Draw();
                }
                Console.Write("\n");                  
            }
        }

        public ACase this[int i, int j]
        {
            get { return grid[i,j]; }
            set { grid[i,j] = value; } 
        }
    }
}

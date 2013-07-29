using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theseus
{
    public class Maze
    {
        private List<List<ICase>> _grid = new List<List<ICase>>(); 
        
        public Maze()
            : this(new List<List<ICase>>())
        { }

        public Maze(List<List<ICase>> grid)
        {
            _grid = grid;
        }

        public ICase this[int x, int y]
        {
            get
            {
                return _grid[x][y];
            }

            set
            {
                _grid[x][y] = value;
            }
        }

        private void Validate()
        {
            int height = _grid.Count;

            if (height == 0)
                throw new Exception("Invalid labyrinth file, Labyrinth is empty");

            int width = _grid[0].Count;
            foreach (var row in _grid)
            {
                if (row.Count != width)
                    throw new Exception("Invalid labyrinth file, Labyrinth width not uniform.");
            }

            /*
            if (!grid.Any(row => row.Contains('P')))
                throw new Exception("Invalid labyrinth file, Labyrinth has no player start position");

            if (!grid.Any(row => row.Contains('E')))
                throw new Exception("Invalid labyrinth file, Labyrinth has no exit marker");
             * */
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var row in _grid)
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
    }
}

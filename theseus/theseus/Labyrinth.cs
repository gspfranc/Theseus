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
    public class Labyrinth
    {
        private List<List<char>> grid = new List<List<char>>(); 
        public Labyrinth(string path)
        {            
            using (StreamReader fs = File.OpenText(path))
            {
                string s = "";
                while((s = fs.ReadLine()) != null)
                {
                    grid.Add(s.ToList());
                }
            }
            Validate();
        }

        public Labyrinth(List<List<char>> grid)
        {
            this.grid = grid;
            Validate();
        }

        private void Validate()
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

            if (!grid.Any(row => row.Contains('P')))
                throw new Exception("Invalid labyrinth file, Labyrinth has no player start position");

            if (!grid.Any(row => row.Contains('E')))
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
    }
}

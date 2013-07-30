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
{   [Serializable()]
    public class Labyrinth : IDrawable
    {
        private ACase[,] grid;
        public Labyrinth(int sizeX, int sizeY)
        {
            grid = new ACase[sizeX, sizeY];
        }

        

        public void Validate()
        {
            int height = grid.GetLength(0);

            if (height == 0)
                throw new Exception("Invalid labyrinth file, Labyrinth is empty");

            int width = grid.GetLength(1);

            Boolean isNull = false;
            var hasPlayer = false;
            var hasExit = false;

            foreach (ACase i in grid)
            {    
                if (i == null)
                    throw new Exception("Invalid labyrinth file, Labyrinth is not rectangle");
                if (i is Exit)
                    hasExit = true;
                if (i is StartPosition)
                    hasPlayer = true;
            }

            if(!hasPlayer)
                throw new Exception("Invalid labyrinth file, No Player is present");
            if (!hasExit)
                throw new Exception("Invalid labyrinth file, No Exit is present");

          
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            var sw = new StringWriter(sb);
            Draw(sw);
            return sw.ToString();
        }

        public void Draw()
        {
            var sb = new StringBuilder();
            var sw = new StringWriter(sb);
            Console.SetOut(sw);
            Draw(sw);

        }


        public void Draw(StringWriter s)
        {
            for (int i = 0; i != grid.GetLength(0); ++i)
            {
                for (int j = 0; j != grid.GetLength(1); ++j)
                {
                    grid[i, j].Draw(s);
                }
                s.Write("\n");                  
            }
        }

        public ACase this[int i, int j]
        {
            get { return grid[i,j]; }
            set { grid[i,j] = value; } 
        }

      
    }
}

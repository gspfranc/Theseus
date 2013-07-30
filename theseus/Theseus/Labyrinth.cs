using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theseus.Case;
using System.Drawing;


namespace Theseus
{   [Serializable()]
    public class Labyrinth : IDrawable
    {
        private ACase[,] grid;
        List<ACase> playerStartPosition = new List<ACase>();
        private List<Player> player = new List<Player>();
        private List<ADude> dudes= new List<ADude>();

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
            for(int i=0; i != grid.;++i)
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

        public void AddPlayer(Player p)
        {
            player.Add(p);
            dudes.Add(p);
        }

        public void Draw()
        {
            var sb = new StringBuilder();
            var sw = new StringWriter(sb);
            Console.SetCursorPosition(0, 0);
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
            foreach(var dude in dudes)
            {
                Console.SetCursorPosition(dude.Coord.X, dude.Coord.Y);
                dude.Draw();
            }
        }

        private void SpawnAll()
        {

        }

        public bool Play()
        {

            player[0].Coord = playerStartPosition[0].Coord;

            Console.SetWindowSize(grid.GetLength(0), grid.GetLength(1) + 1);
            Console.SetBufferSize(grid.GetLength(0), grid.GetLength(1) + 1);
            ConsoleKey ck;
            Draw();
            while ((ck = Console.ReadKey().Key) != ConsoleKey.Escape)
            {
                foreach (var p in player)
                { 
                    if(p.gamePad.up == ck)
                        this[p.Coord.X, p.Coord.Y - 1].MoveIn(p);
                    else if (p.gamePad.down == ck)
                        this[p.Coord.X, p.Coord.Y + 1].MoveIn(p);
                    else if (p.gamePad.left == ck)
                        this[p.Coord.X - 1, p.Coord.Y].MoveIn(p);
                    else if (p.gamePad.right == ck)
                        this[p.Coord.X + 1, p.Coord.Y].MoveIn(p);
                }
                Draw();
            }
            
            return false;
        }

        public ACase this[int i, int j]
        {
            get { return grid[i,j]; }
            set 
            { 
                grid[i,j] = value;
                grid[i, j].Coord = new Point(i, j);
                if (value.IsPlayerSpawn())
                {
                    playerStartPosition.Add(value);
                }
            } 
        }

      
    }
}

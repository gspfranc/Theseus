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
{
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

        public Labyrinth(List<List<ACase>> grid)
        {
            for (int i = 0; i != grid.Count; ++i)
            {
                for(int j=0; i!= grid[i].Count; ++j)
                    this.grid[i,j] = grid[i][j];
            }            
            Validate();
        }

        #region stuff
        public void Validate()
        {
            int height = grid.Length;

            if (height == 0)
                throw new Exception("Invalid labyrinth file, Labyrinth is empty");
            /*
            foreach(var case in grid)
            {

            }

            if (!grid.Any(a=>a is DungeonStartPosition))
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
        #endregion

        public void AddPlayer(Player p)
        {
            player.Add(p);
            dudes.Add(p);
        }

        public void Draw()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i != grid.GetLength(0); ++i)
            {
                for (int j = 0; j != grid.GetLength(1); ++j)
                {
                    grid[i, j].Draw();
                }
                Console.Write("\n");                  
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

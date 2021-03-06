﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theseus.Case;
using System.Drawing;
using Theseus.Music;
using System.Threading;


namespace Theseus
{
    [Serializable()]
    public class Maze : IDrawable, IGame, IMazeObserver
    {
        public enum NotifyType {Victory, DeathFromTrap, DeathFromMinotaur, Running}

        private ACase[,] grid;
        private const int RADIUS_VIEW = 3;
        List<ACase> playerStartPosition = new List<ACase>();
        private List<Player> player = new List<Player>();
        private List<ADude> dudes= new List<ADude>();
        private IGameEngine ge = new GameEngineConsole();
        private IGameState gs = new GameStateRunning();
        public ISong song { get; set; }
        private List<MazeMessage> messages= new List<MazeMessage>();


        public Maze(int sizeX, int sizeY)
        {
            grid = new ACase[sizeX, sizeY];            
        }

        public void SetGameState(IGameState gameState)
        {
            gs = gameState;
        }

        public void Validate()
        {
            int height = grid.GetLength(0);

            if (height == 0)
                throw new Exception("Invalid labyrinth file, Labyrinth is empty");

            int width = grid.GetLength(1);
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

        public void AddPlayer(Player p)
        {
            player.Add(p);
            dudes.Add(p);
        }

        public void RemoveDude(ADude dude)
        {
            player.Remove(dude as Player);
            if (player.Count == 0)
                SetGameState(new GameStateLost());
            dudes.Remove(dude);
        }

        public void Draw()
        {
            Draw(ge);
        }

        public void Draw(IGameEngine s)
        {
            Point p = player[0].Coord;
            var e = new DungeonEmpty();
            
            foreach (ACase c in grid)
            {
                if (Math.Abs(c.Coord.X - p.X) < RADIUS_VIEW && Math.Abs(c.Coord.Y - p.Y) < RADIUS_VIEW)
                    c.Draw(s);
                else
                    e.Coord = c.Coord;
                    e.Draw(s);

            }

            foreach(var dude in dudes)
            {
                dude.Draw(s);
            }
        }

        public bool Play()
        {
            if (song != null)
                song.play();

            player[0].Coord = playerStartPosition[0].Coord;

            Console.Clear();
            Console.CursorVisible = false;
            Console.SetWindowSize(Math.Max(grid.GetLength(1) + 1, 14), grid.GetLength(0)); // La console requiert une largeur minimale de 14 caratères.
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            ConsoleKey ck;

            Draw();
            while (gs.isRunning() && (ck = Console.ReadKey().Key) != ConsoleKey.Escape)
            {
                foreach (var p in player)
                {
                    if(p.gamePad.up == ck)
                        this[p.Coord.X-1, p.Coord.Y].MoveIn(p);
                    else if (p.gamePad.down == ck)
                        this[p.Coord.X+1, p.Coord.Y].MoveIn(p);
                    else if (p.gamePad.left == ck)
                        this[p.Coord.X, p.Coord.Y-1].MoveIn(p);
                    else if (p.gamePad.right == ck)
                        this[p.Coord.X, p.Coord.Y+1].MoveIn(p);
                }

                Draw();

                foreach(var message in messages)
                {
                    message.DoAction(this);
                }
                messages.Clear();
            }

            return gs.isVictory();
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

        public void SendMessage(MazeMessage message)
        {
            messages.Add(message);
        }
    }
}

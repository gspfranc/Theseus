using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Theseus.Case;
using Theseus.Music;

namespace Theseus
{
    /// <summary>
    /// Objet servant à créer un maze à partir d'un fichier texte.
    /// Possède les gamepads des différents joueurs.
    /// </summary>
    public class MazeReader
    {
        private AbstractFactoryMaze afm;
        private List<GamePad> gamePads = new List<GamePad>();

        public void AddGamePad(GamePad gp)
        {
            gamePads.Add(gp);
        }

        private AbstractFactoryMaze GetAbstractFactory(String s)
        {
            switch(s)
            {
                //ajouter les autres factory ici
                case "dungeon" :
                default : return new ConcreteFactoryMaze_Dungeon();
            }
        }

        private ACase GetCase(String s, Maze maze)
        {
            switch (s)
            {
                case "=": return afm.CreateWall();
                case "o": return afm.CreateEmpty();
                case "*": return afm.CreatePortal3();
                case "X": return afm.CreateTrap();
                case "E": return afm.CreateExit(maze);
                case "P": return afm.CreateStartPosition();
            }

            return afm.CreateEmpty();
        }

        private ISong getSong(String s, String path)
        {
            switch (s)
            {
                case "wav": return new WavSong(path);
                case "console": return new ConsoleSong(path);
                default: throw new Exception("Invalid Song type.");
            }
        }

        public String GetLine(StreamReader sr)
        {
            if (sr.EndOfStream)
                throw new Exception("DUMBASS");
            return sr.ReadLine();
        }

        /// <summary>
        /// Fonction de création d'un maze unique à partir d'un fichier.
        /// </summary>
        /// <param name="path">Path du fichier définissant le maze</param>
        public Maze CreateMaze(String path)
        {
            StreamReader sr = new StreamReader(path);

            afm = GetAbstractFactory(GetLine(sr));
            int x = int.Parse(GetLine(sr));
            int y = int.Parse(GetLine(sr));
            String song = GetLine(sr);
            String[] songs= song.Split(' ');
                  

            Maze maze = new Maze(x, y);
            maze.song = getSong(songs[0], songs[1]);

            foreach (var gp in gamePads)
                maze.AddPlayer(new Player(gp, maze));

            int i = 0;
            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();
                String[] blocks = line.Split(' ');
                int j= 0;
                foreach (String block in blocks)
                {
                    maze[i, j] = GetCase(block, maze);
                    ++j;
                }
                ++i;
            }

            maze.Validate();

            return maze;
        }

        /// <summary>
        /// Fonction de création d'une suite de maze à partir d'un dossier.
        /// Prendra tous les fichiers d'un dossier et tentera de créer un maze pour ensuite les
        /// insérer dans un MultiGame.
        /// </summary>
        /// <param name="path">Path du dossier contenant les fichiers de maze</param>
        public MultiGame CreateMazes(String path)
        {
            MultiGame mg = new MultiGame();

            foreach (String file in Directory.GetFiles(path))
            {
                mg.AddGame(CreateMaze(file));
            }

            return mg;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Theseus.Case;

namespace Theseus
{
    public class MazeReader
    {
        

        private AbstractFactoryMaze afm;

        private AbstractFactoryMaze GetAbstractFactory(String s)
        {
            switch(s)
            {
                //case "blooddragon" : return new ConcreteFactoryMaze_80s();
                case "dungeon" :
                default : return new ConcreteFactoryMaze_Dungeon();
            }
        }

        private ACase GetCase(String s)
        {
            switch (s)
            {
                case "=": return afm.CreateWall();
                case "o": return afm.CreateEmpty();
                case "*": return afm.CreatePortal3();
                case "X": return afm.CreateTrap();
                case "E": return afm.CreateExit();
                case "P": return afm.CreateStartPosition();
            }

            return afm.CreateEmpty();
        }

        public Labyrinth CreateMaze(String path)
        {
            StreamReader sr = new StreamReader(path);

            if (sr.EndOfStream)
                throw new Exception("DUMBASS");

            afm = GetAbstractFactory(sr.ReadLine());
            Labyrinth maze = new Labyrinth();

            int i = 0;
            while (!sr.EndOfStream)
            {
                String line = sr.ReadLine();
                String[] blocks = line.Split(' ');
                int j= 0;
                foreach (String block in blocks)
                {
                    maze[i,j]= GetCase(block);
                    ++j;
                }
                ++i;
            }

            maze.Validate();

            return maze;
        }
    }
}

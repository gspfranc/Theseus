using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Theseus;
using System.IO;
using System.Text;
using Theseus.Case;

namespace TheseusTest
{
    [TestClass]
    public class LabyrinthTest
    {
        static Wall w = new DungeonWall();
        static Empty e = new DungeonEmpty();
        static Exit z = new DungeonExit();
        static DungeonStartPosition p = new DungeonStartPosition();

       

        [TestMethod]
        public void NoPlayer()
        {
            try
            {
                var sb = new StringBuilder();

                sb.AppendLine("dungeon");
                sb.AppendLine("9");
                sb.AppendLine("6");
                sb.AppendLine("= = = = = =");
                sb.AppendLine("= o = = = =");
                sb.AppendLine("= o = E o =");
                sb.AppendLine("= o = = o =");
                sb.AppendLine("= o = = o =");
                sb.AppendLine("= o o o o =");
                sb.AppendLine("= o = = = =");
                sb.AppendLine("= o o o o =");
                sb.AppendLine("= = = = = =");

                var fileContent = sb.ToString();

                string fileName = "testNoPlayer.txt";
                File.WriteAllText(fileName, fileContent);
                MazeReader reader = new MazeReader();
                var labyrinth = reader.CreateMaze(fileName);
            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail("No exception thrown");
        }

        [TestMethod]
        public void NoExit()
        {
            try
            {
                var sb = new StringBuilder();

                sb.AppendLine("dungeon");
                sb.AppendLine("9");
                sb.AppendLine("6");
                sb.AppendLine("= = = = = =");
                sb.AppendLine("= P = = = =");
                sb.AppendLine("= o = o o =");
                sb.AppendLine("= o = = o =");
                sb.AppendLine("= o = = o =");
                sb.AppendLine("= o o o o =");
                sb.AppendLine("= o = = = =");
                sb.AppendLine("= o o o o =");
                sb.AppendLine("= = = = = =");

                var fileContent = sb.ToString();

                string fileName = "TestNoExit.txt";
                File.WriteAllText(fileName, fileContent);
                MazeReader reader = new MazeReader();
                var labyrinth = reader.CreateMaze(fileName);


            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail("No exception thrown");
        }

        [TestMethod]
        public void NotRectangle()
        {
            try
            {
                var sb = new StringBuilder();

                sb.AppendLine("dungeon");
                sb.AppendLine("9");
                sb.AppendLine("6");
                sb.AppendLine("= = = = = =");
                sb.AppendLine("= P = = = =");
                sb.AppendLine("= o = E o =");
                sb.AppendLine("= o = = o =");
                sb.AppendLine("= o =");
                sb.AppendLine("= o o o o =");
                sb.AppendLine("= o = = = =");
                sb.AppendLine("= o o o o =");
                sb.AppendLine("= = = = = =");

                var fileContent = sb.ToString();

                string fileName = "TestNotRectangle.txt";
                File.WriteAllText(fileName, fileContent);
                MazeReader reader = new MazeReader();
                var labyrinth = reader.CreateMaze(fileName);


            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail("No exception thrown");
        }
        [TestMethod]
        public void Empty()
        {
            try
            {
                var sb = new StringBuilder();

                sb.AppendLine("dungeon");
                sb.AppendLine("0");
                sb.AppendLine("0");
                

                var fileContent = sb.ToString();

                string fileName = "TestEmpty.txt";
                File.WriteAllText(fileName, fileContent);
                MazeReader reader = new MazeReader();
                var labyrinth = reader.CreateMaze(fileName);
            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail("No exception thrown");
        }


    }
}
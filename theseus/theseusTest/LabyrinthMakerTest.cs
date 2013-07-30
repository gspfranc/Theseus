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
    public class LabyrinthMakerTest
    {
        [TestMethod]
        public void makeWithFileName()
        {
            var sb = new StringBuilder();

            sb.AppendLine("dungeon");
            sb.AppendLine("= = = = = =");
            sb.AppendLine("= P = = = =");
            sb.AppendLine("= o = E o =");
            sb.AppendLine("= o = = o =");
            sb.AppendLine("= o = = o =");
            sb.AppendLine("= o o o o =");
            sb.AppendLine("= o = = = =");
            sb.AppendLine("= o o o o =");
            sb.AppendLine("= = = = = =");

            var fileContent = sb.ToString();

            string fileName = "testLoadFromFileDisplay.txt";
            File.WriteAllText(fileName, fileContent);
            MazeReader reader = new MazeReader();
            var labyrinth = reader.CreateMaze(fileName);
            Assert.IsTrue(fileContent.Equals(labyrinth.ToString()));
        }
    }
}

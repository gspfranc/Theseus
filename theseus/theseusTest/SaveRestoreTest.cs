using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Theseus;
using System.IO;

namespace TheseusTest
{
    [TestClass]
    public class SaveRestoreTest
    {
        [TestMethod]
        public void TestSaveRestore()
        {
            var sb = new StringBuilder();

            sb.AppendLine("dungeon");
            sb.AppendLine("9");
            sb.AppendLine("6");
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

            string fileName = "testSaveRestore.txt";
            File.WriteAllText(fileName, fileContent);
            MazeReader reader = new MazeReader();
            var labyrinth = reader.CreateMaze(fileName);
            

            var saveRestore = new SaveRestore();
            saveRestore.save("save.dat", labyrinth);
            var lab2 = saveRestore.restore("save.dat");

            Assert.IsTrue(labyrinth.ToString() == lab2.ToString());     
        }
    }
}

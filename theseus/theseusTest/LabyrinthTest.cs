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
        public void Valid()
        {



            var validGrid = new List<List<ACase>>
            {
                
                new List<ACase> {w, w, w, w, w, w },
                new List<ACase> {w, p, w, w, w, w },
                new List<ACase> {w, e, w, z, e, w },
                new List<ACase> {w, e, w, w, e, w },
                new List<ACase> {w, e, w, w, e, w },
                new List<ACase> {w, e, e, e, e, w },
                new List<ACase> {w, e, w, w, w, w },
                new List<ACase> {w, w, w, w, w, w }
            };

            var lab = new Labyrinth(validGrid);
        }

        [TestMethod]
        public void NoPlayer()
        {
            try
            {
                var noPlayerGrid = new List<List<ACase>>
                {
                    new List<ACase> {w, w, w, w, w, w },
                    new List<ACase> {w, e, w, w, w, w },
                    new List<ACase> {w, e, w, z, e, w },
                    new List<ACase> {w, e, w, w, e, w },
                    new List<ACase> {w, e, w, w, e, w },
                    new List<ACase> {w, e, e, e, e, w },
                    new List<ACase> {w, e, w, w, w, w },
                    new List<ACase> {w, w, w, w, w, w }
                };

                var lab = new Labyrinth(noPlayerGrid);
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
                var noExitGrid = new List<List<ACase>>
                {
                    new List<ACase> {w, w, w, w, w, w },
                    new List<ACase> {w, p, w, w, w, w },
                    new List<ACase> {w, e, w, e, e, w },
                    new List<ACase> {w, e, w, w, e, w },
                    new List<ACase> {w, e, w, w, e, w },
                    new List<ACase> {w, e, e, e, e, w },
                    new List<ACase> {w, e, w, w, w, w },
                    new List<ACase> {w, w, w, w, w, w }
                };

                var lab = new Labyrinth(noExitGrid);

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
                var notRectangleGrid = new List<List<ACase>>
                {
                    new List<ACase> {w, w, w, w, w, w },
                    new List<ACase> {w, p, w, w, w, w },
                    new List<ACase> {w, e, w, z, e, w },
                    new List<ACase> {w, e, w },
                    new List<ACase> {w, e, w, w, e, w },
                    new List<ACase> {w, e, e, e, e, w },
                    new List<ACase> {w, e, w, w, w, w },
                    new List<ACase> {w, w, w, w, w, w }
                };

                var lab = new Labyrinth(notRectangleGrid);

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
                var emptyGrid = new List<List<ACase>>();

                var lab = new Labyrinth(emptyGrid);
            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail("No exception thrown");
        }

        /*[TestMethod]
        public void LoadFromFileDisplay()
        {
            var sb = new StringBuilder();
            sb.AppendLine("======");
            sb.AppendLine("=P====");
            sb.AppendLine("= =E =");
            sb.AppendLine("= == =");
            sb.AppendLine("= == =");
            sb.AppendLine("=    =");
            sb.AppendLine("= ====");
            sb.AppendLine("=    =");
            sb.AppendLine("======");

            var fileContent = sb.ToString();

            string fileName = "testLoadFromFileDisplay.txt";
            File.WriteAllText(fileName, fileContent);
            var labyrinth = new Labyrinth(fileName);
            Assert.IsTrue(fileContent.Equals(labyrinth.ToString()));
        }
        //*/
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Theseus;
using System.IO;
using System.Text;

namespace TheseusTest
{
    [TestClass]
    public class LabyrinthTest
    {
        [TestMethod]
        public void Valid()
        {
            var validGrid = new List<List<char>>
            {
                new List<char> {'=', '=', '=', '=', '=', '=' },
                new List<char> {'=', 'P', '=', '=', '=', '=' },
                new List<char> {'=', ' ', '=', 'E', ' ', '=' },
                new List<char> {'=', ' ', '=', '=', ' ', '=' },
                new List<char> {'=', ' ', '=', '=', ' ', '=' },
                new List<char> {'=', ' ', ' ', ' ', ' ', '=' },
                new List<char> {'=', ' ', '=', '=', '=', '=' },
                new List<char> {'=', '=', '=', '=', '=', '=' }
            };

            var lab = new Labyrinth(validGrid);
        }

        [TestMethod]
        public void NoPlayer()
        {
            try
            {
                var noPlayerGrid = new List<List<char>>
                {
                    new List<char> {'=', '=', '=', '=', '=', '=' },
                    new List<char> {'=', ' ', '=', '=', '=', '=' },
                    new List<char> {'=', ' ', '=', 'E', ' ', '=' },
                    new List<char> {'=', ' ', '=', '=', ' ', '=' },
                    new List<char> {'=', ' ', '=', '=', ' ', '=' },
                    new List<char> {'=', ' ', ' ', ' ', ' ', '=' },
                    new List<char> {'=', ' ', '=', '=', '=', '=' },
                    new List<char> {'=', '=', '=', '=', '=', '=' }
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
                var noExitGrid = new List<List<char>>
                {
                    new List<char> {'=', '=', '=', '=', '=', '=' },
                    new List<char> {'=', 'P', '=', '=', '=', '=' },
                    new List<char> {'=', ' ', '=', 'E', ' ', '=' },
                    new List<char> {'=', ' ', '=', '=', ' ', '=' },
                    new List<char> {'=', ' ', '=', '=', ' ', '=' },
                    new List<char> {'=', ' ', ' ', ' ', ' ', '=' },
                    new List<char> {'=', ' ', '=', '=', '=', '=' },
                    new List<char> {'=', '=', '=', '=', '=', '=' }
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
                var notRectangleGrid = new List<List<char>>
                {
                    new List<char> {'=', '=', '=', '=', '=', '=' },
                    new List<char> {'=', 'P', '=', '=', '=', '=' },
                    new List<char> {'=', ' ', '=', 'E', ' ', '=' },
                    new List<char> {'=', ' ', '=' },
                    new List<char> {'=', ' ', '=', '=', ' ', '=' },
                    new List<char> {'=', ' ', ' ', ' ', ' ', '=' },
                    new List<char> {'=', ' ', '=', '=', '=', '=' },
                    new List<char> {'=', '=', '=', '=', '=', '=' }
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
                var emptyGrid = new List<List<char>>();

                var lab = new Labyrinth(emptyGrid);
            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail("No exception thrown");
        }

        [TestMethod]
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
    }
}
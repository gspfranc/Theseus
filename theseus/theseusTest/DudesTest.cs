using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Theseus;

namespace TheseusTest
{
    class MockMazeObserver : IMazeObserver
    {
        public bool MessageReceived { get; private set; }

        public MockMazeObserver()
        {
            MessageReceived = false;
        }

        public void SendMessage(MazeMessage message)
        {
            MessageReceived = true;
        }
    }

    [TestClass]
    public class DudesTest
    {
        [TestMethod]
        public void TestPlayer()
        {
            var obs = new MockMazeObserver();
            ADude player = new Player(new GamePad(), obs);
            player.ReceiveDammage(player.health);

            Assert.IsTrue(obs.MessageReceived);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using acmp_0004_Game_Csharp;

namespace UnitTestGame
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGame_input_5()
        {
            int number = 5;
            int expected = 594;
            Game g = new Game();
            int actual = g.game(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGame_input_2()
        {
            int number = 2;
            int expected = 297;
            Game g = new Game();
            int actual = g.game(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGame_input_7()
        {
            int number = 7;
            int expected = 792;
            Game g = new Game();
            int actual = g.game(number);
            Assert.AreEqual(expected, actual);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bowling_game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bowling_gameTests;

namespace bowling_game.Tests
{
    [TestClass()]
    public class ProgramProgram
    {
        private Game g;

        /// <summary>
        /// TestContext 
        /// Used to store information that is provided to unit tests.
        /// </summary>
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestInitialize]
        public void Initialize()
        {
            g = new Game();    
        }

        /// <summary>
        /// clean when test method ready
        /// </summary>

        [TestCleanup]
        public void Cleanup()
        {
            g = null;
        }


        [TestMethod]
        public void TestGutter()
        {
            int rolls = 20;
            int pins = 0;
            RollMany(rolls, pins);
            Assert.AreEqual(0,g.Score());
            Console.WriteLine("Score :" + g.Score());
            Console.WriteLine("Test Gutter Success");
        }


        [TestMethod]
        public void TestAllOne()
        {
           
            RollMany(20,1);
            Assert.AreEqual(20, g.Score());
            Console.WriteLine("Score :" + g.Score());
            Console.WriteLine("Test All One Success");
            Console.Write("Test make a change");
        }


        [TestMethod]
        public void TestOneSpare()
        {
            RollSpare();
            g.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, g.Score());
            Console.WriteLine("Score :" + g.Score());
//            Assert.Inconclusive();
            Console.WriteLine("Test One Spare Success");
        }

        private void RollSpare()
        {
            // spare
            g.Roll(5);
            g.Roll(5);
        }

        [TestMethod]
        public void TestStrike()
        {
            RollStrike();
            g.Roll(3);
            g.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, g.Score());
            Console.WriteLine("Score :" + g.Score());
            Console.WriteLine("Test Strike Success");
        }

        private void RollStrike()
        {
            g.Roll(10);
        }

        public void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                g.Roll(pins);
            }
        }

        [TestMethod]
        public void TestPerfactGame()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, g.Score());
            Console.WriteLine("Score :" + g.Score());
            Console.WriteLine("Test Perfact Game Success");
        }

    }
}

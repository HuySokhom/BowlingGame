using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bowling_game.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bowling_gameTestsTests;

namespace bowling_game.Tests.Tests
{
    [TestClass()]
    public class ProgramProgramTests
    {
        private BowlingGame Game;
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

        /*
         *  Initialize when system run 
         */

        [TestInitialize]
        public void Initialize()
        {
            Game = new BowlingGame();
        }

        /// <summary>
        /// Clean when TestMethod ready
        /// </summary>

        [TestCleanup]
        public void Cleanup()
        {
            Game = null;
        }

        [TestMethod()]
        public void TestMethod()
        {
            Console.WriteLine("Hello");
        }

        [TestMethod]
        public void TestGutterGame()
        {
            RollMany(20,0);
            /*
             * Assert.AreEqual method is use to verify 
             * two value is equal
            */
            Assert.AreEqual(0,Game.Score());
            Console.WriteLine("Success");
            Console.WriteLine("Value 0 = "+ Game.Score());
        }

        [TestMethod]
        public void TestAllOne()
        {
            RollMany(20,1);
            Assert.AreEqual(20, Game.Score());

            Console.WriteLine("Success Test All One");
            Console.WriteLine("Value 20 = " + Game.Score());
        }

        public void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                Game.Roll(pins);
            }
        }

        [TestMethod]
        public void TestOneSpare()
        {
            Game.Roll(5);
            Game.Roll(5);
            Game.Roll(3);
            RollMany(17,0);
            Assert.AreEqual(16,Game.Score());
           
            Console.WriteLine("Value 16 = "+ Game.Score());
        }

        [TestMethod]
        public void TestStrike()
        {
            Game.Roll(10);
            Game.Roll(3);
            Game.Roll(4);
            RollMany(16,0);
            Assert.AreEqual(24,Game.Score());

            Console.WriteLine("Value of strike is Expected 24  and actual " + Game.Score());
        }

        [TestMethod]
        public void TestPerfactGame()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, Game.Score());
            Console.WriteLine("Value of strike is Expected 300  and actual " + Game.Score());
        }
    }
}

using System;
using System.Collections.Generic;
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
            

            for (int i = 0; i < 20; i++)
            {
                Game.Roll(0);
            }

            /*
             * Assert.AreEqual method is use to verify 
             * two value is equal
            */
            Assert.AreEqual(0,Game.Score());

            Console.WriteLine("Success ");
        }
    }
}

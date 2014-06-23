using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bowling_game
{
    [TestClass()]
    public class BowlingGame
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

        /// <summary>
        /// initialize when application running
        /// </summary>
      
        [TestInitialize()]
        public void Initialize()
        {
            Game g = new Game();
        }

        /// <summary>
        /// clean when test method ready
        /// </summary>
        
        [TestCleanup()]
        public void Cleanup()
        {
            g = null;
        }

        [TestMethod()]
        public void TestGutterGame()
        {
            RollMany(20, 1);

            /*
             * Assert.AreEqual 
             * use to compare 2 object is equal
            */

            Assert.AreEqual(0,g.Score());
        }


        [TestMethod()]
        public void TestAllOne()
        {
            RollMany(20, 1);
            Assert.AreEqual(20,g.Score());
        }

        
        public void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                g.Roll(pins);
            }
        }

        [TestMethod()]
        public void TestOneSpare()
        {
            RollSpare();
            g.Roll(3);
            RollMany(17, 0);

            Assert.AreEqual(16, g.Score());
        }

        private void RollSpare()
        {
            g.Roll(5);
            /* spare */
            g.Roll(5);
        }

        [TestMethod()]
        public void TestStrike()
        {
            RollStrike();
            g.Roll(3);
            g.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, g.Score());

        }

        private void RollStrike()
        {
            g.Roll(10);
        }

        [TestMethod()]
        public void TestPerfactGame()
        {
            RollMany(12,10);
            Assert.AreEqual(300, g.Score());
        }
    }

}

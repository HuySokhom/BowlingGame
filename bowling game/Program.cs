using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace bowling_game
{

    [TestClass]
    public class Program
    {
        private Game g;
        private static void Main(string[] args)
        {
            var p= new Program();
            Console.WriteLine("Hello World !");
            Console.WriteLine(p.Score(10,10));
            Console.ReadLine();
            
        }

        [TestMethod]

        public int Score(int a, int b)
        {
            int total = a + b;
            return total;
        }

    }
}
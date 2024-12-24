using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEG.DataDrivenTesting
{
    internal class TestParameterUsingTestCase
    {
        [TestCase(1, 2, 3)]
        [TestCase(5, 9, 4)]
        [TestCase(2, 10, 6)]

        public void ThreeSum(int x, int y, int z)
        {
            int c = x + y + z;
            Assert.AreEqual(c, x+y+z);
            //Console.WriteLine($"Sum is {c}");
        }
    }
}

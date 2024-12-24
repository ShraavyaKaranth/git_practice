using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEG.NunitTests
{
    internal class ignoreTests
    {
        [Test, Order(1), Ignore("not needed/ Defect ID 1234")]
        public void testCase1()
        {
            Console.WriteLine("Test case 1");
        }
        [Test, Order(3)]
        public void testCase3()
        {
            Console.WriteLine("Test case 3");
        }
        [Test, Order(2)]
        public void testCase2()
        {
            Console.WriteLine("Test case 2");
        }
    }
}

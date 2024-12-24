using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEG.NunitTests
{
    internal class Test1
    {
        [Test, Description("Testing the first test case")]
        public void test1()
        {
            Console.WriteLine("First test case is executed!");
        }
    }
}

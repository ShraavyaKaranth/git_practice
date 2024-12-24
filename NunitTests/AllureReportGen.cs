using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEG.NunitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class AllureReportGen
    {
        [Test]
        public void test1()
        {
            Console.WriteLine("Test Case 1 passed");
        }
    }
}

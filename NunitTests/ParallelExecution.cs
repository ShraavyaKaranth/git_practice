using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEG.NunitTests
{
    [Parallelizable(ParallelScope.All)]
    internal class ParallelExecution
    {
        [Test]
        public void products()
        {
            Console.WriteLine("User selects product");
        }
        [Test]
        public void userreg()
        {
            Console.WriteLine("User Registration completed");
        }
        [Test]
        public void login()
        {
            Console.WriteLine("User is logged in");
        }
    }
}

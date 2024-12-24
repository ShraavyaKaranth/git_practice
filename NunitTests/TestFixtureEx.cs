using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEG.NunitTests
{
    [TestFixture, Description("This is a Sanity Test suite"), Category("Sanity")]
    internal class TestFixtureEx
    {
        [Test, Order(3)]
        public void products()
        {
            Console.WriteLine("User selects product");
        }
        [Test, Order(1)]
        public void userreg()
        {
            Console.WriteLine("User Registration completed");
        }
        [Test, Order(2)]
        public void login()
        {
            Console.WriteLine("User is logged in");
        }

        [Test, Order(4)]
        public void addToCart()
        {
            Console.WriteLine("User adds product to cart");
        }
        [Test, Order(5)]
        public void payment()
        {
            Console.WriteLine("User has paid successfully.");
        }
    }
}

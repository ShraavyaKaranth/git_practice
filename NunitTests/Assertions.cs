using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestingEG.NunitTests
{
    internal class Assertions
    {
        [Test]
        public void assertmethod()
        {
            String actual = "Shravya";
            String expected = "SHKAR";
            String exp2 = "shravya";
            //if (actual == expected)
            //{
            //    Console.WriteLine("The results are matching");
            //}
            //else
            //{
            //    Console.WriteLine("The results are not matching");
            //}

            //Assert.AreEqual(actual, expected);
            Assert.AreNotEqual(actual, expected);
            //Assert.AreSame(actual, expected);
            Assert.AreNotSame(actual, expected);
            //assert that
            //Assert.That(actual, Is.EqualTo(expected));
            Assert.That(actual, Is.Not.EqualTo(expected));
            //ignorecase
            Assert.That(actual, Is.EqualTo(exp2).IgnoreCase);
            //Assert.That(actual, Is.EqualTo(expected).IgnoreCase);
            //substring
            Assert.That(actual, Does.Contain("vYa").IgnoreCase);
            ////empty assertions
            //Assert.IsEmpty(actual);
            //Assert.IsNotEmpty(actual);
            //Assert.IsTrue(actual.Equals(expected));
            //Assert.IsNull(expected);
            //Assert.IsNotNull(expected);
            ////collection constraints
            int[] array = new int[] { 1, 2, 8, 4, 3, 6};
            Assert.NotNull(array);
            Assert.That(array, Is.All.GreaterThan(0));
            //Assert.IsEmpty(array);
            //Assert.That(array, Is.Ordered.Ascending);
            ////custom exception
            int age = 19;
            if (age < 18)
            {
                throw new AssertionException("User is not eligible for marriage");
            }
        }
    }
}

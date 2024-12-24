using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEG.DataDrivenTesting
{
    internal class TestParameterUsingTestCaseSource
    {
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + " : " + password);
        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("Shravya", "hehe");
            yield return new TestCaseData("Shravya2", "haha") ;
            yield return new TestCaseData("Shravya3", "hehehe");
            yield return new TestCaseData("Shravya4", "hahaha");
        }
        
        //[TestCaseSource(nameof(listOfData))]

        //public void ThreeSum(int x, int y, int z)
        //{
        //    int c = x + y + z;
        //    Assert.AreEqual(c, x + y + z);
        //    Console.WriteLine($"Sum is {c}");
        //}
        //public static object[] listOfData =
        //{
        //    new object[] {1,2,3 },
        //    new object[] {4,5,6},
        //    new object[] {7,8,9},
        //};
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSeleniumC_Training.Utilities;

namespace TestingEG.DataDrivenTesting
{
    internal class TestParameterUsingExcel : NUnitSeleniumC_Training.Utilities.ExcelRead
    {
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + " : " + password);
        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            var columns = new List<string> { "Username", "Password" };
            return ExcelRead.GetTestDataFromExcel("C:\\Users\\shkar\\source\\repos\\TestingEG\\TestingEG\\testdatanew.xlsx", "Sheet1", columns);
        }
    }
}

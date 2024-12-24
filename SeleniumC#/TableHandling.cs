using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestingEG.SeleniumC_
{
    [Category("Table")]
    internal class TableHandling
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            //launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //initialize the web driver
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void testcase1()
        {
            //launch application URL
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            //fetch table
            IWebElement tables = driver.FindElement(By.Id("table1"));
            //fetch rows
            List<IWebElement> trrow = new List<IWebElement>(tables.FindElements(By.XPath("//table[@id = 'table1']/tbody/tr")));
            int rowCount = trrow.Count();
            Console.WriteLine($"there are {rowCount} number of rows");
            //fetch columns
            List<IWebElement> tdcol = new List<IWebElement>(tables.FindElements(By.XPath("//table[@id = 'table1']/tbody/tr[1]/td")));
            int colCount = tdcol.Count();
            Console.WriteLine($"there are {colCount} number of columns");
            //celldata text
            IWebElement celldata = driver.FindElement(By.XPath("//table[@id = 'table1']/tbody/tr[1]/td[2]"));
            string text = celldata.Text;
            Console.WriteLine(text);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            Assert.AreEqual("John", text);

        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}

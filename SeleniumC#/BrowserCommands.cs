using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestingEG.SeleniumC_
{
    internal class BrowserCommands
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            //launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //initialize the web driver
            driver = new EdgeDriver();
        }
        [Test]
        public void testcase1()
        {
            //launch application URL
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            //browser commands
            //get title of url
            string title = driver.Title;
            Console.WriteLine($"Title : {title}");
            //get url
            string currentURL = driver.Url;
            Console.WriteLine($"Current URL: {currentURL}");
            //get pagesource
            string pagesource = driver.PageSource;
            Console.WriteLine($"Page Source : {pagesource}");
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}

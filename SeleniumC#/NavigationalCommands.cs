using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.DevTools.V129.Page;

namespace TestingEG.SeleniumC_
{
    internal class NavigationalCommands
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
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("https://www.facebook.com/");

            //navigate commands
            //navigate back
            driver.Manage().Window.Maximize();
            driver.Navigate().Back();
            Thread.Sleep(5000);
            //Navigate forward
            driver.Navigate().Forward();
            Thread.Sleep(5000);
            //navigate refresh
            driver.Navigate().Refresh();
            Thread.Sleep(5000);
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}

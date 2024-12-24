using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestingEG.SeleniumC_
{
    internal class dragAndDrop
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
            Thread.Sleep(5000);

            IWebElement a = driver.FindElement(By.Id("column-a"));
            IWebElement b = driver.FindElement(By.Id("column-b"));


            Actions actions = new Actions(driver);

            
            actions.DragAndDrop(a,b)
                  
                   .Pause(TimeSpan.FromSeconds(5))
                   .Click()
                   .Build()
                   .Perform();
            Console.WriteLine("working");
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}

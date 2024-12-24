using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace TestingEG.SeleniumC_.window_handling
{
    [Category("Window")]

    internal class WindowTabHandling
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            //fetch window handle
            string parentHandle = driver.CurrentWindowHandle;
            IWebElement ClickHere = driver.FindElement(By.XPath("//a[normalize-space()='Click Here']"));
            ClickHere.Click();
            //fetch the window handles of all windows(two windows opened)
            IList<string> windowHandles = new List<string>(driver.WindowHandles);
            //move control to child window
            driver.SwitchTo().Window(windowHandles[1]);
            string title = driver.Title;
            Console.WriteLine(title);

            Thread.Sleep(3000);
            Console.WriteLine("Closing child window");
            driver.Close();
            driver.SwitchTo().Window(windowHandles[0]);
            //driver.SwitchTo().DefaultContent();
            string parentTitle = driver.Title;
            Console.WriteLine(parentTitle);
            Assert.AreEqual("The Internet", parentTitle);   
            Thread.Sleep(3000);


        }
        [TearDown]
        public void closeBrowser()
        {
            Console.WriteLine("Closing parent window");
            driver.Close();
        }
    }
}

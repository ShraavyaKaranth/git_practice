//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium;
//using WebDriverManager.DriverConfigs.Impl;
//using OpenQA.Selenium.Interactions;
//using System.Windows;

//namespace TestingEG.SeleniumC_
//{
//    internal class ActionsPractice
//    {
//        IWebDriver driver;
//        [SetUp]
//        public void startBrowser()
//        {
//            //launch chrome browser
//            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
//            //initialize the web driver
//            driver = new EdgeDriver();
//            driver.Manage().Window.Maximize();

//        }
//        [Test]
//        public void testcase1()
//        {
//            //launch application URL
//            driver.Navigate().GoToUrl("https://www.amazon.in/");
//            Thread.Sleep(5000);

//            IWebElement primeelement = driver.FindElement(By.XPath("//span[normalize-space()='Prime']"));
//            //IWebElement image = driver.FindElement(By.Id("multiasins-img-link"));
//            //IWebElement starting = driver.FindElement(By.Id("CardInstanceXgBZtpaKtdRGDHYmxPc4sA"));
//            //new OpenQA.Selenium.Interactions.Actions(driver)
//            //    .MoveToElement(primeelement).Perform();
//            //    .MoveToElement(image)
//            //    .Perform();
//            //    .Pause(TimeSpan.FromSeconds(1))
//            //    .Click();
//            //Thread.Sleep(5000);
//            Actions actions = new Actions(driver);

//            // Perform actions: Hover over Prime, then hover over the image, and click
//            actions.MoveToElement(primeelement)
//                //Click(starting)


//                //.Pause(TimeSpan.FromSeconds(5))
//                   //.MoveToElement(image)
//                   .Pause(TimeSpan.FromSeconds(5))
//                   .Click()
//                   .Build()
//                   .Perform();
//            Console.WriteLine("working");
//            IWebElement image = driver.FindElement(By.Id("multiasins-img-link"));

//            actions.MoveToElement(image)
//                .Pause(TimeSpan.FromSeconds(5))
//                   .Click()
//                   .Build()
//                   .Perform();
//            Console.WriteLine("working image");
//        }
//        [TearDown]
//        public void closeBrowser()
//        {
//            driver.Close();
//        }
//    }
//}

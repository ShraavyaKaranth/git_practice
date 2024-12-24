//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium;
//using WebDriverManager.DriverConfigs.Impl;

//namespace TestingEG.SeleniumC_
//{
//    internal class Locators
//    {
//        IWebDriver driver;
//        [SetUp]
//        public void startBrowser()
//        {
//            //launch chrome browser
//            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
//            //initialize the web driver
//            driver = new EdgeDriver();
//        }
//        [Test]
//        public void testcase1()
//        {
//            //launch application URL
//            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/register.php");
//            //locators
//            //ID
//            Thread.Sleep(5000);
//            IWebElement FirstName = driver.FindElement(By.Id("firstname"));
//            FirstName.SendKeys("Shravya");
//            Thread.Sleep(5000);
//            IWebElement LastName = driver.FindElement(By.Id("lastname"));
//            LastName.SendKeys("Karanth");
//            Thread.Sleep(5000);
//            IWebElement UserName = driver.FindElement(By.Id("username"));
//            UserName.SendKeys("SHKAR");
//            Thread.Sleep(5000);
//            IWebElement Password = driver.FindElement(By.Id("password"));
//            Password.SendKeys("Hehe@123");
//            Thread.Sleep(5000);
//            //IWebElement Register = driver.FindElement(By.TagName("(//input)[5]"));
//            //Register.Click();
//            Thread.Sleep(5000);
//            IWebElement BacktoLogin = driver.FindElement(By.LinkText("Back to Login"));
//            BacktoLogin.Click();
//            Thread.Sleep(5000);
//            IWebElement BacktoLog = driver.FindElement(By.PartialLinkText("Back to Log"));
//            BacktoLog.Click();
//            //  Css selectorr
//            IWebElement Elements = driver.FindElement(By.CssSelector("button[data-bs-target='#collapseOne']"));
//            Elements.Click();
//            // tag name 
//            IWebElement input = driver.FindElement(By.TagName("(//input)[1]"));
//            input.SendKeys("jkkj");
//            // class name 
//            IWebElement classname = driver.FindElement(By.ClassName("(//input[@class = 'form-control'])[1]"));
//            classname.SendKeys("jkkj");
//        }
//        [TearDown]
//        public void closeBrowser()
//        {
//            driver.Close();
//        }
//    }
//}

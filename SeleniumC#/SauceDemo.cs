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
    internal class SauceDemo
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
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/index.html");
            //locators
            //ID
            Thread.Sleep(5000);
            IWebElement UserName = driver.FindElement(By.Id("user-name"));
            UserName.SendKeys("standard_user");
            Thread.Sleep(5000);
            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("secret_sauce");
            Thread.Sleep(5000);
            IWebElement Login = driver.FindElement(By.Id("login-button"));
            Login.Click();
            Thread.Sleep(5000);
            IWebElement Products = driver.FindElement(By.XPath("//div[@class='product_label']"));

            //Displayed validation

            if (Products.Displayed)
            {
                Console.WriteLine("User is on the homepage.");
            }
            else
            {
                Console.WriteLine("User is not on the homepage.");
            }
            Thread.Sleep(8000);
            //assertion class validation
            string actualtext = Products.Text;
            string expectedvalue = "Products";
            Assert.AreEqual(actualtext, expectedvalue);
            Console.WriteLine(actualtext + " is equal to "+expectedvalue);
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}

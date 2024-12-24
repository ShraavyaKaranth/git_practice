using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestingEG.NunitTests
{
    [Allure.NUnit.AllureNUnit]
    [Parallelizable(ParallelScope.All)]
    internal class parallel2
    {
        IWebDriver driver;

        [SetUp]
        public void startbrowser()
        {
            // launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }

        [Test, Category("P1")]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }


        [Test, Category("P1")]
        public void testcase2()
        {
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
        }


        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }



    }
}

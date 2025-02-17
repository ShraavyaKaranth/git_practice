﻿using System;
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
    internal class dropdownLab
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");

            Thread.Sleep(5000);
            

            IWebElement dropdownlist = driver.FindElement(By.Id("dropdown"));
            dropdownlist.Click();
            Assert.IsNotNull(dropdownlist);
            var select = new SelectElement(dropdownlist);
            Thread.Sleep(3000);
            //select by Index
            select.SelectByIndex(1);
            Thread.Sleep(3000);
            //select by value
            select.SelectByValue("2");
            Thread.Sleep(3000);
            //select by visible text
            select.SelectByText("Option 1");
            Thread.Sleep(3000);
            


        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}

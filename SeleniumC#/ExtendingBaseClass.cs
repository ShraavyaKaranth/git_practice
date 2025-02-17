﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using TestingEG.Utilities;

namespace TestingEG.SeleniumC_
{
    internal class ExtendingBaseClass : Base
    {
        [Test]
        public void testcase1()
        {
            Console.WriteLine("Starting test case...");
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
            Console.WriteLine("Test case completed.");
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium;
//using WebDriverManager.DriverConfigs.Impl;

//namespace TestingEG.SeleniumC_
//{
//    internal class ExtendingBaseClass : Utilities.Base
//    {
//        IWebDriver driver = null;
//        public ExtendingBaseClass(IWebDriver driver)
//        {
//            this.driver = driver;
//        }
//        [Test]
//        public void testcase1()
//        {

//            //launch application URL
//            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");

//            Thread.Sleep(5000);


//            IWebElement dropdownlist = driver.FindElement(By.Id("dropdown"));
//            dropdownlist.Click();
//            Assert.IsNotNull(dropdownlist);
//            var select = new SelectElement(dropdownlist);
//            Thread.Sleep(3000);
//            //select by Index
//            select.SelectByIndex(1);
//            Thread.Sleep(3000);
//            //select by value
//            select.SelectByValue("2");
//            Thread.Sleep(3000);
//            //select by visible text
//            select.SelectByText("Option 1");
//            Thread.Sleep(3000);

//        }

//    }
//}

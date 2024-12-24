using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Support.UI;

namespace TestingEG.SeleniumC_
{
    internal class radio_buttons
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
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            
            Thread.Sleep(5000);
            //IWebElement Radio = driver.FindElement(By.XPath("//input[@value='radio1']"));
            //if (Radio.Enabled)
            //{
            //    Console.WriteLine("Radio is enabled, so clicking on it.");
            //}
            //Radio.Click();
            //Thread.Sleep(5000);


            //IWebElement Country = driver.FindElement(By.Id("autocomplete"));
            //Country.SendKeys("INDIA");
            //Thread.Sleep(5000);
            //IWebElement India = driver.FindElement(By.Id("ui-id-52"));
            //India.Click();
            //Thread.Sleep(4000);

            //IWebElement dropdownlist = driver.FindElement(By.Id("dropdown-class-example"));
            //dropdownlist.Click();
            //Assert.IsNotNull(dropdownlist);
            //var select = new SelectElement(dropdownlist);
            //Thread.Sleep(3000);
            ////select by Index
            //select.SelectByIndex(1);
            //Thread.Sleep(3000);
            ////select by visible text
            //select.SelectByText("Option3");
            //Thread.Sleep(3000);
            ////select by value
            //select.SelectByText("option2");
            //Thread.Sleep(3000);


            //IWebElement CheckBox1 = driver.FindElement(By.Id("checkBoxOption1"));
            //CheckBox1.Click();
            //Thread.Sleep(5000);
            //IWebElement CheckBox2 = driver.FindElement(By.Id("checkBoxOption2"));
            //CheckBox2.Click();
            //Thread.Sleep(5000);
            //CheckBox2.Click();
            //Thread.Sleep(5000);
            //IWebElement CheckBox3 = driver.FindElement(By.Id("checkBoxOption3"));
            //CheckBox3.Click();


            //Checkbox list

            //IReadOnlyList<IWebElement> CheckBoxList = driver.FindElements(By.XPath("//input[@type='checkbox']"));
            //foreach (IWebElement checkbox in CheckBoxList)
            //{
            //    checkbox.Click();
            //}
            //Thread.Sleep(5000);


            IWebElement AlertMessage = driver.FindElement(By.Id("name"));
            AlertMessage.SendKeys("Shravya");
            Thread.Sleep(5000);
            IWebElement AlertButton = driver.FindElement(By.Id("alertbtn"));
            AlertButton.Click();
            IAlert alt = driver.SwitchTo().Alert();
            Thread.Sleep(3000);

            Console.WriteLine("Alert button clicked");
            //clicking OK button
            alt.Accept();
            Console.WriteLine("OK button clicked");
            Thread.Sleep(3000);

            AlertMessage.SendKeys("Shravya");
            Thread.Sleep(5000);
            IWebElement ConfirmButton = driver.FindElement(By.Id("confirmbtn"));
            ConfirmButton.Click();
            Console.WriteLine("Confirm button clicked");
            Thread.Sleep(3000);
            alt.Dismiss();
            Console.WriteLine("cancel button clicked");
            //Handling Informational Alerts

            //IWebElement Products = driver.FindElement(By.XPath("//div[@class='product_label']"));

            ////Displayed validation

            //if (Products.Displayed)
            //{
            //    Console.WriteLine("User is on the homepage.");
            //}
            //else
            //{
            //    Console.WriteLine("User is not on the homepage.");
            //}
            //Thread.Sleep(8000);


            //assertion class validation
            //string actualtext = Products.Text;
            //string expectedvalue = "Products";
            //Assert.AreEqual(actualtext, expectedvalue);
            //Console.WriteLine(actualtext + " is equal to " + expectedvalue);
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
        
    }

}


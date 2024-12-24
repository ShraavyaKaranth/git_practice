using System;
using System.Configuration;
//using System.Configuration.ConfigurationManager
//using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace TestingEG
{
    public class Base
    {
        public IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            Console.WriteLine("Starting browser setup...");

            string browserName = ConfigurationManager.AppSettings["browser"];
            Console.WriteLine($"Browser name from config: {browserName}");
            if (string.IsNullOrEmpty(browserName))
            {
                throw new ArgumentException("Browser name is not specified in the configuration file.");
            }
            InitBrowser(browserName);
            driver.Manage().Window.Maximize();
            Console.WriteLine("Browser setup completed.");
        }

        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentException($"Browser not supported: {browserName}");
            }
            Console.WriteLine($"Initialized {browserName} driver.");
        }

        [TearDown]
        public void tearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
                driver = null;
                Console.WriteLine("Browser closed and resources disposed.");
            }
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////using Microsoft.Extensions.Configuration;
//using OpenQA.Selenium;
////using Microsoft.Extensions
//using System.Configuration;
//using OpenQA.Selenium.Firefox;
//using WebDriverManager.DriverConfigs.Impl;

//namespace TestingEG.Utilities
//{
//    public class Base
//    {
//        public IWebDriver driver;
//        [SetUp]
//        public void startBrowser()
//        {
//            string browserName = System.Configuration.ConfigurationManager.AppSettings["browser"];
//            InitBrowser(browserName);
//            driver.Manage().Window.Maximize();

//        }
//        public void InitBrowser(string browserName)
//        {
//            switch (browserName)
//            {
//                case "Firefox":
//                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
//                    break;
//                case "Chrome":
//                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
//                    break;
//                case "Edge":
//                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
//                    break;
//            }
//        }

//        [TearDown]
//        public void tearDown()
//        {
//            if(driver != null)
//            {
//                driver.Quit();
//                driver.Dispose();
//                driver = null;
//            }

//        }
//    }
//}

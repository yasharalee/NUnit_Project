using NUnit_Project.ProjectBusinessLayer.DataAccess;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace NUnit_Project.ProjectName.Tests.TestHelpers
{
    public class Driver
    {
        private static IWebDriver driver = null;

        private Driver() { }

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                switch (Qa_1_Env.Browser)
                {
                    case "Firefox":
                        driver = new FirefoxDriver();
                        break;
                    case "Chrome":
                    default:
                        driver = new ChromeDriver();
                        break;
                }
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                return driver;
            }

            return driver;
        }

        public static void DestroyDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}

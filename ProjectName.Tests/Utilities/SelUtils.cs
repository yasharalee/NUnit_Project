using NUnit_Project.ProjectName.Tests.TestHelpers;
using OpenQA.Selenium;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Project.ProjectName.Tests.Utilities
{
    class SelUtils
    {
        private static IWebDriver driver = Driver.GetDriver();

        public static void clickBtnByText(String BtnText)
        {
            try
            {
                driver.FindElement(By.XPath("//Button[text()='" + BtnText + "']")).Click();
            }
            catch (NoSuchElementException e)
            {
                driver
                    .FindElement(By.XPath("//input[@role='button'][@value='" + BtnText + "']"))
                    .Click();
            }
        }

 
    }
}

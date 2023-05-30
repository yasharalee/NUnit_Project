using NUnit_Project.ProjectName.Tests.TestHelpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Project.ProjectName.Tests.PageObjects
{
    class Google
    {
        private IWebDriver driver;

        public Google()
        {
            this.driver = Driver.GetDriver();
        }

        private IWebElement searchInput => driver.FindElement(By.Name("q"));
        private IWebElement SearchButton => driver.FindElement(By.Name("btnK"));

        public void sendStringToSearch(String content)
        {
            searchInput.SendKeys(content);
        }
    }
}

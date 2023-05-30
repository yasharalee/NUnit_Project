using NUnit.Framework;
using NUnit_Project.ProjectBusinessLayer.DataAccess;
using NUnit_Project.ProjectName.Tests.PageObjects;
using NUnit_Project.ProjectName.Tests.TestHelpers;
using NUnit_Project.ProjectName.Tests.Utilities;
using OpenQA.Selenium;

namespace NUnit_Project.ProjectName.Tests.TestCases
{
    [TestFixture]
    public class GoogleTest
    {
        Google google = new Google();

        [Test]
        public void googleTest()
        {
            IWebDriver driver = Driver.GetDriver();
            driver.Navigate().GoToUrl(Qa_1_Env.BaseUrl);
            google.sendStringToSearch("doff");
            SelUtils.clickBtnByText("Google Search");
            Driver.DestroyDriver();
        }
    }
}

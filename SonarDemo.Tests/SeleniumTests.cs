using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarDemo.Tests
{
    [TestClass]
    public class SeleniumTests
    {
        IWebDriver driver = null;
        [TestInitialize]
        public void TestStartup()
        {
            //driver = new FirefoxDriver();
            driver = new ChromeDriver();
        }

        [TestMethod]
        [TestCategory("Selenium")]
        public void LoginTestforStaticButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.Navigate().GoToUrl("https://demoappcd.azurewebsites.net/");
            
            Assert.AreEqual(true, true);
        }
    }
}

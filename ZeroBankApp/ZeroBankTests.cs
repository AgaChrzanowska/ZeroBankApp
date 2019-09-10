using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ZeroBankApp
{
    [TestClass]
    public class ZeroBankTests
    {
        private static IWebDriver _driver = new ChromeDriver();

        [TestInitialize]
        public void SetUp()
        {
            _driver.Navigate().GoToUrl("http://zero.webappsecurity.com/login.html");
        }

        [TestMethod]
        public void Check_H1_Text()
        {
            IWebElement h1 = _driver.FindElement(By.ClassName("page-header"));
            Assert.AreEqual("Log in to ZeroBank", h1.Text);
        }

        [TestCleanup]
        public void Close()
        {
            _driver.Dispose();
        }
    }
}

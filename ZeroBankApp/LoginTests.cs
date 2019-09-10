using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ZeroBankApp
{
    [TestClass]
    public class LoginTests
    {
        private IWebDriver _driver;
        private LoginPageObject _loginPageObject;

        [TestInitialize]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _loginPageObject = new LoginPageObject(_driver);

            _driver.Navigate().GoToUrl("http://zero.webappsecurity.com/login.html");
        }

        [TestMethod]
        public void Check_H1_text()
        {
            Assert.AreEqual("Log in to ZeroBank", _loginPageObject.GetH1Text());
        }

        [TestCleanup]
        public void Close()
        {
            _driver.Dispose();
        }
    }
}

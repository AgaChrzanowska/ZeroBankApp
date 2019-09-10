using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroBankApp
{
    public class LoginPageObject
    {
        public IWebDriver Driver { get; set; }

        [FindsBy(How = How.ClassName, Using = "page-header")]
        public IWebElement H1 { get; set; }

        public LoginPageObject(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public string GetH1Text()
        {
            return H1.Text;
        }
    }
}

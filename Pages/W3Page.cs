using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.Pages
{
     public class W3Page
    {
        private IWebDriver driver;
        public W3Page(IWebDriver driver)
        {
            this.driver = driver;
        }
        By Signup = By.XPath("//*[@class='user-anonymous tnb-signup-btn w3-bar-item w3-button w3-right ws-green ws-hover-green ga-top ga-top-signup']");

        public void SignupClick ()
        {
            driver.FindElement(Signup).Click();
        }
    }
}

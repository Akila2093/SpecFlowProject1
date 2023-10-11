using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.Pages
{
   public class W3SignupPage
    {
        private IWebDriver driver;
        public W3SignupPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By Signupforfree = By.XPath("//*[@id='signUpFromSignup']");

        public void SignupforfreeClick()
        {
            driver.FindElement(Signupforfree).Click();
        }

        
    }
}

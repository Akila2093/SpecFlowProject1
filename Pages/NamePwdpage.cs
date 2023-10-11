using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.Pages
{
  public class NamePwdpage
    {
        private IWebDriver driver;
        public NamePwdpage(IWebDriver driver)
        {
            this.driver = driver;
        }
        By email = By.XPath("//*[@name='email']");
        By Password = By.XPath("//*[@name='new-password']");
        By Signupfree = By.XPath("//*[@class='Button_button__URNp+ Button_primary__d2Jt3 Button_fullwidth__0HLEu']");

        public void emailenter()
        {
            driver.FindElement(email).SendKeys("prya@gmail.com");
        }
        public void pwdenter()
        {
            driver.FindElement(Password).SendKeys("Wipro@123");
        }
        public void freesignUpClick()
            {
            driver.FindElement(Signupfree).Click();
        }
        By FirstName = By.XPath("//*[@name='first_name']");
        By LastName = By.XPath("//*[@name='last_name']");
        By Continue = By.XPath("//*[@class='Button_button__URNp+ Button_primary__d2Jt3 Button_fullwidth__0HLEu']");
        public void firstname()
        {
            driver.FindElement(FirstName).SendKeys("Wipro");
        }
        public void Lastname()
        {
            driver.FindElement(LastName).SendKeys("Tech");
        }
        public void ContinueClick()
        {
            driver.FindElement(Continue).Click();
        }
    }
}

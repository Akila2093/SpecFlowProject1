using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject1.Pages;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class Signup
    {
        private IWebDriver driver;
        //W3Page W3Page;

        [Given(@"open browser")]
         public void GivenOpenBrowser()
        {
          driver = new ChromeDriver();
        }

        [Given(@"Go to w(.*) schoold link")]
        public void GivenGoToWSchooldLink(int p0)
        {
            driver.Url = "https://www.w3schools.com/";
            Thread.Sleep(5000);
        }


        [When(@"click on sign up")]
        public void ThenClickOnSignUp()
        {
            W3Page page = new W3Page(driver);
            page.SignupClick();

        }

        [Then(@"clikc on sign up for free")]
        public void ThenClikcOnSignUpForFree()
        {
            W3SignupPage page1 = new W3SignupPage(driver);
            page1.SignupforfreeClick();
        }


        [Then(@"enter email id")]
        public void ThenEnterEmailId()
        {
            NamePwdpage nm = new NamePwdpage(driver);
            nm.emailenter();

        }

        [Then(@"enter password")]
        public void ThenEnterPassword()
        {
            NamePwdpage nm = new NamePwdpage(driver);
            nm.pwdenter();
        }

        [Then(@"Clikc on sogn up for free")]
        public void ThenClikcOnSognUpForFree()
        {
            NamePwdpage nm = new NamePwdpage(driver);
            nm.freesignUpClick();
        }

        [Then(@"Enter First Name")]
        public void ThenEnterFirstName()
        {
            NamePwdpage nm = new NamePwdpage(driver);
            nm.firstname();

        }

        [Then(@"Enter Last Name")]
        public void ThenEnterLastName()
        {
            NamePwdpage nm = new NamePwdpage(driver);
            nm.Lastname();
        }

        [Then(@"Click Continue")]
        public void ThenClickContinue()
        {
            NamePwdpage nm = new NamePwdpage(driver);
            nm.ContinueClick();
        }
        [Then(@"Close Browser")]
        public void CloseBrowser()
        {
            driver.Quit();
        }

    }

}
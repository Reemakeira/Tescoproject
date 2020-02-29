using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Tescoproject.Base;
using Tescoproject.Page;
using TechTalk.SpecFlow;




namespace Tescoproject.Step
{
    [Binding]
    [Scope(Tag ="Tesco")]
   public class Tescosigninstep:Setup
        
    {
        public IWebDriver browser;
        Tescosigninpage Newpage;
        [Given(@"Navigate to Tesco")]
        public void GivenNavigateToTesco()
        {
            browser = driver;
            browser.Navigate().GoToUrl("https://www.tesco.com/");
        }

        [When(@"I enter correct email address and password")]
        public void WhenIEnterCorrectEmailAddressAndPassword()
        {
            Newpage = new Tescosigninpage(browser);
            Newpage.Clickonsignin();
            
        }

        [Then(@"I can see welcome page")]
        public void ThenICanSeeWelcomePage()
        {
            Newpage.verifywelcomepage();
        }
    }
}
    


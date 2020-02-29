using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Shouldly;
using FluentAssertions;
using OpenQA.Selenium.Firefox;



namespace Tescoproject.Page
{
    class TescoRecipespage
    {
        public IWebDriver Driver;
        public TescoRecipespage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
            

            
        }
        [FindsBy(How = How.CssSelector, Using = "div.ui-components-library nav.navigation:nth-child(6) div.nav-large ul.nav-large-container:nth-child(1) li.nav-bar-item-wrapper:nth-child(6) div.nav-dropdown div.dropdown.onclick > a.nav-toggle.false")]
        public IWebElement clickonRecipes;
        [FindsBy(How = How.LinkText, Using = "Baking")]
        public IWebElement clickonBaking;



        public string Bakingurl = "https://realfood.tesco.com/baking.html?icid=dchp_nav";

        public void Clickonrecipes()
        {
          
            clickonRecipes.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Task.Delay(6000).Wait();
            Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\Neil\source\repos\Tescoproject\page\Baking.aa.jpeg", ScreenshotImageFormat.Jpeg);
            Task.Delay(8000).Wait();
        }
        public void ClickonBaking()
        {
            clickonBaking.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
        public void verifyBakingrecipespage()
        {
           Driver.Url.Contains(Bakingurl).Should().BeTrue();
           
        }
       


    }
}

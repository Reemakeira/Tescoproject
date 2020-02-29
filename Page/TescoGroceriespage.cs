using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using Shouldly;
using OpenQA.Selenium.Firefox;

namespace Tescoproject.Page
{
  
 public class TescoGroceriespage
    {
        public IWebDriver Driver;
        public TescoGroceriespage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }
      [FindsBy(How = How.CssSelector, Using = "div.ui-components-library nav.navigation:nth-child(6) div.nav-large ul.nav-large-container:nth-child(1) li.nav-bar-item-wrapper:nth-child(1) div.nav-dropdown div.dropdown.onclick > a.nav-toggle.false")]
       public IWebElement clickonGroceries;
        [FindsBy(How = How.ClassName,Using = "nav-link-label")]
        public IWebElement clickonShopgroceries;

        public string Reasonstoshopwithus= "https://www.tesco.com/groceries/?icid=dchp_groceriesshopgroceries";

        public void clickongroceries()
        {
            clickonGroceries.Click();
        }
        public void ClickonShopgroceries()
        {
            
            clickonShopgroceries.Click();
            
           
            
        }
        
        public void checkReasonstoshopwithus()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(1000,1000)");
            


            Driver.Url.Contains(Reasonstoshopwithus).Should().BeTrue();


        }




    }

    }


    


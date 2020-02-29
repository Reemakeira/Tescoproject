using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shouldly;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using System;

namespace Tescoproject.Page
{
    public class Tescosigninpage
    {
        public IWebDriver Driver;
        public Tescosigninpage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }
           [FindsBy(How = How.CssSelector, Using = "li:nth-child(5) > div > a > span.link-text")]
           public IWebElement clickonmyAccount;
           [FindsBy(How = How.CssSelector, Using = "#username")]
            public IWebElement emailaddress;
        [FindsBy(How = How.CssSelector, Using = "#password")]
        public IWebElement password;
        [FindsBy(How = How.CssSelector, Using = "div.ui-component__grid div.mytesco-container div.main.login-form div.login-form__wrapper div.ui-component__panel div.form-container form:nth-child(1) button.ui-component__button:nth-child(6) > span:nth-child(1)")]
        public IWebElement clickonsignin;
        [FindsBy(How = How.LinkText, Using = "welcomemessage")]
        public IWebElement welcomemessage;

        public string welcomeurl = "https://secure.tesco.com/account/en-GB/manage/";


        public void Clickonsignin()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            clickonmyAccount.Click();
            emailaddress.SendKeys("reema.shah85@gmail.com");
            password.SendKeys("Keirashah2014");
            clickonsignin.Click();
        }
        public void verifywelcomepage()
        {
            welcomemessage.Text.Contains(welcomeurl).Should().BeTrue();

        }

    }
    }


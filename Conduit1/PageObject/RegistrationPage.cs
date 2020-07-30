using Conduit1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Conduit1.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement signUp => driver.FindElement(By.XPath("//a[contains(text(), 'Sign up')]"));

        IWebElement username => driver.FindElement(By.XPath("//input[@type='text']"));

        IWebElement email => driver.FindElement(By.XPath("//input[@placeholder='Email']"));

        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));

        IWebElement SignUp2 => driver.FindElement(By.XPath("//button[@type='submit']"));


        public void ClickOnSignUp()
        {
            signUp.Click();
        }

        public void EnterUsername()
        {
            Thread.Sleep(5000);
            username.SendKeys("Ogunshola1");
        }

        public void EnterEmail()
        {
            email.SendKeys("folake.richardson@talktalk.net");
        }

        public void EnterPassword()
        {
            password.SendKeys("PasswordSecured");
        }

        public void ClickOnSignUp2()
        {
            SignUp2.Click();
        }


        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }

    }





}

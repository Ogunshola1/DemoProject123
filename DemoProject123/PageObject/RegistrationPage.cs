using DemoProject123.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject123.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;
        

        IWebElement helloSignIn => driver.FindElement(By.XPath("//*[@id='nav-link-accountList']/div/span"));
        
        IWebElement CreateYourAmazonAccount1 => driver.FindElement(By.Id("createAccountSubmit"));

        IWebElement yourName => driver.FindElement(By.Id("ap_customer_name"));

        IWebElement email => driver.FindElement(By.CssSelector("#ap_email"));

        IWebElement password => driver.FindElement(By.CssSelector("#ap_password"));

        IWebElement reEnterpassword => driver.FindElement(By.CssSelector("#ap_password_check"));

        IWebElement CreateYourAmazonAccount2 => driver.FindElement(By.CssSelector("#continue"));


        public void ClickOnHelloSignIn()
        {
            helloSignIn.Click();
        }

        public void ClickOnCreateYourAmazonAccount1()
        {
            CreateYourAmazonAccount1.Click();
        }

        public void EnterYourName()
        {
            yourName.SendKeys("Folake");
        }

        public void EnterEmail()
        {
            email.SendKeys("folake.richardson@talktalk.net");
        }

        public void EnterPassword()
        {
            password.SendKeys("PasswordSecure");
        }

        public void EnterPassword2()
        {
            reEnterpassword.SendKeys("PasswordSecure");
        }

        public void ClickOnCreateYourAmazonAccount2()
        {
            CreateYourAmazonAccount2.Click();
        }

        public void NavigateTowebsite()
        {
            driver.Navigate().GoToUrl("https://www.amazon.co.uk");
        }

        





        



    }
}

using Conduit1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conduit1.PageObject
{
    class DataDrivenWithParameterPage

    {
        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement usernameInput => driver.FindElement(By.XPath("//Input[@placeholder = 'Username']"));

        IWebElement emailInput => driver.FindElement(By.XPath("//Input[@placeholder = 'Email']"));

        IWebElement passwordInput => driver.FindElement(By.XPath("//Input[@placeholder = 'Password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[@type = 'submit']"));

        IWebElement userLogin => driver.FindElement(By.XPath("//a[@class='nav-link ng-binding']"));

      



        public void EnterUsername(string oyindamola)
        {
            //Random randomGenerator = new Random();
            //int randomint = randomGenerator.Next(1000);
            //usernameInput.SendKeys(username + randomint);
            usernameInput.SendKeys("oyindamola");
        }
        public void EnterEmail(string amala)
        {
            //Random randomGenerator = new Random();
            //int randomint = randomGenerator.Next(1000);
            //emailInput.SendKeys(amala + randomint + "@talktalk.net");
            emailInput.SendKeys("amala");
        }

        public void EnterPassword(string password)
        {
            passwordInput.SendKeys("password");
        }

        public void ClickSignUpButton()
        {
            signUpButton.Click();
        }

        public bool IsUserLoginDisplayed()
        {
            return userLogin.Displayed;
        }
        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }








    }
}

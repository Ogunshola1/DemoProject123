using Conduit1.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Conduit1.StepDefinition
{
    [Binding]
    public class DataDrivenWithParametersSteps
    {
        DataDrivenWithParameterPage datadrivenwithparameterPage;

        public DataDrivenWithParametersSteps()
        {
            datadrivenwithparameterPage = new DataDrivenWithParameterPage();
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            datadrivenwithparameterPage.NavigateToWebsite(url);
        }
        
        [When(@"I enter username text ""(.*)""")]
        public void WhenIEnterUsernameText(string oyindamola)
        {
            datadrivenwithparameterPage.EnterUsername(oyindamola);
        }
        
        [When(@"I enter email text ""(.*)""")]
        public void WhenIEnterEmailText(string amala)
        {
            datadrivenwithparameterPage.EnterEmail(amala);
        }
        
        [When(@"I enter password text ""(.*)""")]
        public void WhenIEnterPasswordText(string password)
        {
            datadrivenwithparameterPage.EnterPassword(password);
        }
        
        [When(@"I click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            datadrivenwithparameterPage.ClickSignUpButton();
        }
        
        [Then(@"I am logged in with my username displayed")]
        public void ThenIAmLoggedInWithMyUsernameDisplayed()
        {
            Assert.That(datadrivenwithparameterPage.IsUserLoginDisplayed);
        }
    }
}

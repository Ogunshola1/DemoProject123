using Conduit1.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Conduit1.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }

        [Given(@"I navigate to angularjs website")]
        public void GivenINavigateToAngularjsWebsite()
        {
            registrationPage.NavigateToWebsite();
        }
        
        [When(@"I click on Sign up")]
        public void WhenIClickOnSignUp()
        {
            registrationPage.ClickOnSignUp();
        }
        
        [When(@"I enter my username")]
        public void WhenIEnterMyUsername()
        {
            registrationPage.EnterUsername();
        }
        
        [When(@"I enter my email")]
        public void WhenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [When(@"I sign up on registration page")]
        public void WhenISignUpOnRegistrationPage()
        {
            registrationPage.ClickOnSignUp2();
        }
        
        [Then(@"my account should be created")]
        public void ThenMyAccountShouldBeCreated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

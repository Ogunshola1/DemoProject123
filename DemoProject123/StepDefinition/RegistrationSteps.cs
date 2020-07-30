using DemoProject123.PageObject;
using System;
using TechTalk.SpecFlow;

namespace DemoProject123.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }
        
        
        
        [Given(@"I navigate to amazon website")]
        public void GivenINavigateToAmazonWebsite()
        {
            registrationPage.NavigateTowebsite();
        }

        [When(@"I click on Hello sign in")]
        public void WhenIClickOnHelloSignIn()
        {
            registrationPage.ClickOnHelloSignIn();
        }

        [When(@"I click on create amazon account")]
        public void WhenIClickOnCreateAmazonAccount()
        {
            registrationPage.ClickOnCreateYourAmazonAccount1();
        }

        [When(@"I enter my name")]
        public void WhenIEnterMyName()
        {
            registrationPage.EnterYourName();
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

        [When(@"I re enter my password")]
        public void WhenIReEnterMyPassword()
        {
            registrationPage.EnterPassword2();
        }

        [When(@"I create your amazon accounbt on the registration page")]
        public void WhenICreateYourAmazonAccountOnTheRegistrationPage()
        {
            registrationPage.ClickOnCreateYourAmazonAccount2();
        }

        [Then(@"my account should be created")]
        public void ThenMyAccountShouldBeCreated()
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"I created another step for demo purpose")]
        public void WhenICreatedAnotherStepForDemoPurpose()
        {
            ScenarioContext.Current.Pending();
        }

        }

    }


       

















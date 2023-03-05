using OpenQA.Selenium;
using SpecFlowBDDAutomationFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {

        private IWebDriver driver;
        private LoginPage loginPage;


        public LoginStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"User navigates to login page")]
        public void GivenUserNavigatesToLoginPage()
        {
            loginPage = new LoginPage(driver);
            loginPage.NavigatesToLoginPage();
        }


        [When(@"User enters credentials '([^']*)' and '([^']*)'")]
        public void WhenUserEntersCredentialsAnd(string username, string password)
        {
            loginPage.enterCredentials(username, password);
        }

        [When(@"User clicks the login button")]
        public void WhenUserClicksTheLoginButton()
        {
            loginPage.clickLoginButton();
        }

        [Then(@"User sees the products")]
        public void ThenUserSeesTheProducts()
        {
            loginPage.CheckValidLogin();
        }

        [Then(@"User sees the locked out user message")]
        public void ThenUserSeesTheLockedOutUserMessage()
        {
            loginPage.CheckInvalidLoginForLockedUser();
        }

        [Then(@"User sees the problem user images")]
        public void ThenUserSeesTheProblemUser›mages()
        {
            loginPage.CheckLoginForProblemUser();
        }

        [Then(@"User sees the error message")]
        public void ThenUserSeesTheErrorMessage()
        {
            loginPage.CheckInvalidLogin();
        }

        









    }
}

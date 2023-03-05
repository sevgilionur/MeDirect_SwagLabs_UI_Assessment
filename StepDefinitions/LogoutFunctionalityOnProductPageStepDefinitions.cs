using OpenQA.Selenium;
using SpecFlowBDDAutomationFramework.Pages;
using SpecFlowBDDAutomationFramework.Utility;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public class LogoutFunctionalityOnProductPageStepDefinitions
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private ProductPage productPage;


        public LogoutFunctionalityOnProductPageStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [When(@"User clicks on open menu button")]
        public void WhenUserClicksOnOpenMenuButton()
        {
            productPage = new ProductPage(driver);
            productPage.clickMenuButton();
        }

        [When(@"User clicks the log out button")]
        public void WhenUserClicksTheLogOutButton()
        {
            Waits.waitFor(2);
            productPage.clickLogOutButton();
            Waits.waitFor(2);
        }

        [Then(@"User sees the login page")]
        public void ThenUserSeesTheLoginPage()
        {
            loginPage = new LoginPage(driver);
            loginPage.LoginButtonUIsDisplayed();

        }
    }
}

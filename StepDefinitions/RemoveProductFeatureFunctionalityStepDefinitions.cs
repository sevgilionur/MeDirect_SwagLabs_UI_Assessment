using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowBDDAutomationFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public class RemoveProductFeatureFunctionalityStepDefinitions
    {

        private IWebDriver driver;
        private LoginPage loginPage;
        private ProductPage productPage;
        private CartPage cartPage;


        public RemoveProductFeatureFunctionalityStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"User should be able to see added product")]
        public void ThenUserShouldBeAbleToSeeAddedProduct()
        {
            
        }



        [When(@"User clicks on remove button for removing backpack")]
        public void WhenUserClicksOnRemoveButtonForRemovingBackpack()
        {
            cartPage = new CartPage(driver);
            cartPage.removeProduct();
        }

        [Then(@"User sees shopping cart empty")]
        public void ThenUserSeesShoppingCartEmpty()
        {
            cartPage.CartIsEmpty();
        }
    }
}

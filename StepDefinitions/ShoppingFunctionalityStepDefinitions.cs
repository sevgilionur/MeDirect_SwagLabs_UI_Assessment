using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowBDDAutomationFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public class ShoppingFunctionalityStepDefinitions
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private ProductPage productPage;
        private CartPage cartPage;
        private ShoppingPage shoppingPage;

        public ShoppingFunctionalityStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Given(@"User clicks on checkout button")]
        public void GivenUserClicksOnCheckoutButton()
        {
            shoppingPage = new ShoppingPage(driver);
            shoppingPage.clickCheckOutButton();
        }

        [When(@"Enter required data with ""([^""]*)"", ""([^""]*)"" and ""([^""]*)""")]
        public void WhenEnterRequiredDataWithAnd(string firstName, string lastName, string zipCode)
        {
            shoppingPage.shoppingData(firstName, lastName, zipCode);
        }

        [When(@"User clicks on continue button")]
        public void WhenUserClicksOnContinueButton()
        {
            shoppingPage.clickContinueButton();
        }

        [When(@"Verify total payment amount is correct")]
        public void WhenVerifyTotalPaymentAmountİsCorrect()
        {
            double backpackPrice = Double.Parse(driver.FindElement(By.XPath("(//*[@class='inventory_item_price'])")).Text.ToString().Replace("$", ""));
            double tax = Double.Parse(driver.FindElement(By.XPath("//div[@class='summary_tax_label']")).Text.ToString().Replace("Tax: $", ""));
            double totalActual = Double.Parse(driver.FindElement(By.XPath("//div[@class='summary_info_label summary_total_label']")).Text.ToString().Replace("Total: $", ""));
            double totalExpected = backpackPrice + tax;
            Assert.AreEqual(totalExpected, totalActual);
        }

        [When(@"User clicks on finish button")]
        public void WhenUserClicksOnFinishButton()
        {
            shoppingPage.clickFinishButton();
        }

        [Then(@"Confirm order is dispatched")]
        public void ThenConfirmOrderİsDispatched()
        {
            shoppingPage.successfulOrderMessage();
        }

        [When(@"User enter firstname")]
        public void WhenUserEnterFirstname()
        {
            shoppingPage.shoppingData("onur");
        }

        [Then(@"User should be able to see error message to complete required data")]
        public void ThenUserShouldBeAbleToSeeErrorMessageToCompleteRequiredData()
        {
            shoppingPage.errorMessageDisplayed();
        }


    }
}

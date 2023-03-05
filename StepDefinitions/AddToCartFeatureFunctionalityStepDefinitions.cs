using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowBDDAutomationFramework.Pages;
using SpecFlowBDDAutomationFramework.Utility;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public class AddToCartFeatureFunctionalityStepDefinitions
    {

        private IWebDriver driver;
        private LoginPage loginPage;
        private ProductPage productPage;


        public AddToCartFeatureFunctionalityStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [When(@"User clicks the add to cart button for backpack")]
        public void WhenUserClicksTheAddToCartButtonForBackpack()
        {
            productPage = new ProductPage(driver);
            productPage.clickBackPack();
        }

        [When(@"User clicks the add to cart button for tshirt")]
        public void WhenUserClicksTheAddToCartButtonForTshirt()
        {
            productPage.clickTshirt();
        }

        [When(@"User goes to cart page")]
        public void WhenUserGoesToCartPage()
        {
            productPage.clickCartButton();
        }

        [Then(@"User should be able to see added products")]
        public void ThenUserShouldBeAbleToSeeAddedProducts()
        {

            Waits.waitFor(2);
            IWebElement tshirt = driver.FindElement(By.XPath("//*[.='Sauce Labs Bolt T-Shirt']"));
            StringAssert.Contains("T-Shirt", tshirt.Text);

            Waits.waitFor(1);

            IWebElement backPack = driver.FindElement(By.XPath("//*[.='Sauce Labs Backpack']"));
            StringAssert.Contains("Backpack", backPack.Text);



        }

    }
}

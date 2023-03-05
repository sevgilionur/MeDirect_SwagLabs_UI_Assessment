using NUnit.Framework;
using OpenQA.Selenium;

namespace SpecFlowBDDAutomationFramework.Pages
{
    public class ShoppingPage
    {

        private IWebDriver driver;

        public ShoppingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement checkOutButton => driver.FindElement(By.XPath("//*[.='Checkout']"));
        private IWebElement firstName => driver.FindElement(By.Id("first-name"));
        private IWebElement lastName => driver.FindElement(By.Id("last-name"));
        private IWebElement zipCode => driver.FindElement(By.Id("postal-code"));
        private IWebElement continueButton => driver.FindElement(By.Id("continue"));
        private IWebElement finishButton => driver.FindElement(By.Id("finish"));
        private IWebElement orderMessage => driver.FindElement(By.XPath("//*[.='Thank you for your order!']"));
        private IWebElement errorMessage => driver.FindElement(By.XPath("//h3[.='Error: Last Name is required']"));

        public void clickCheckOutButton()
        {
            checkOutButton.Click();
        }

        public void shoppingData(string userName, string userlastName, string postalCode) 
        {
            firstName.SendKeys(userName);
            lastName.SendKeys(userlastName);
            zipCode.SendKeys(postalCode);

        }
        public void shoppingData(string userName)
        {
            firstName.SendKeys(userName);

        }

        public void clickContinueButton()
        {
            continueButton.Click();
        }

        public void clickFinishButton()
        {
            finishButton.Click();
        }

        public void successfulOrderMessage()
        {
            Assert.AreEqual("Thank you for your order!", orderMessage.Text);
        }

        public void errorMessageDisplayed()
        {
            Assert.True(errorMessage.Text.Contains("Error"));
        }

    }
}

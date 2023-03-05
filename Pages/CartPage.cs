using OpenQA.Selenium;
using SpecFlowBDDAutomationFramework.Utility;

namespace SpecFlowBDDAutomationFramework.Pages
{
    public class CartPage
    {
        private IWebDriver driver;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement removeButtonBackPack => driver.FindElement(By.Id("remove-sauce-labs-backpack"));

        public void removeProduct()
        {
            Waits.waitFor(2);
            removeButtonBackPack.Click();
        }
        
        public void CartIsEmpty() {

            //Asserts.assertFalse(removeButtonBackPack.Enabled);
        }

    }
}

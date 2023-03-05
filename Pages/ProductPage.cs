using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowBDDAutomationFramework.Pages
{
    public class ProductPage
    {
        private IWebDriver driver;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement filter => driver.FindElement(By.CssSelector("[class='product_sort_container']"));
        private IWebElement menuButton => driver.FindElement(By.Id("react-burger-menu-btn"));
        private IWebElement logOutButton => driver.FindElement(By.XPath("//a[.='Logout']"));
        private IWebElement backPackAddButton => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        private IWebElement tshirtAddButton => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        private IWebElement cartButton => driver.FindElement(By.ClassName("shopping_cart_link"));


        public void selectFromDropDown(String value)
        {
            SelectElement dropdown = new SelectElement(filter);
            dropdown.SelectByValue(value);

        }

        public void clickMenuButton()
        {
            menuButton.Click();
        }

        public void clickLogOutButton()
        {
            logOutButton.Click();
        }

        public void clickBackPack() {
        backPackAddButton.Click();  
        }

        public void clickTshirt()
        {
            tshirtAddButton.Click();    

        }

        public void clickCartButton()
        {
            cartButton.Click();

        }

    }
}

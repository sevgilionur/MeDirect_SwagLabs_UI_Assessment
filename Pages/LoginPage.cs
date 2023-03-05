using OpenQA.Selenium;
using SpecFlowBDDAutomationFramework.Utility;

namespace SpecFlowBDDAutomationFramework.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement usernameInput => driver.FindElement(By.Id("user-name"));
        private IWebElement passwordInput => driver.FindElement(By.Id("password"));
        private IWebElement loginButton => driver.FindElement(By.Id("login-button"));
        private IWebElement errorMessage => driver.FindElement(By.XPath("//h3[contains(text(),'Epic sadface')]"));

        private IWebElement lockedUserMessage => driver.FindElement(By.XPath("//h3[contains(text(),'locked out')]"));

        private IWebElement problemUserImages => driver.FindElement(By.XPath("//img[@src='/static/media/sl-404.168b1cce.jpg']"));

        private IWebElement productsTitle => driver.FindElement(By.XPath("//span[.='Products']"));


        public void NavigatesToLoginPage()
        {
            driver.Navigate().GoToUrl(TestData.URL);

        }
        public void enterCredentials(string username, string password)
        {
            usernameInput.SendKeys(username);
            passwordInput.SendKeys(password);
        }

        public void clickLoginButton()
        {
            loginButton.Click();
            Waits.waitFor(1);
        }

        public void CheckValidLogin()
        {
            Waits.waitFor(1);
            Asserts.assertTrue(productsTitle.Displayed);
        }

        public void CheckInvalidLogin()
        {
            Waits.waitFor(1);
            Asserts.assertTrue(errorMessage.Displayed);
        }
        public void CheckInvalidLoginForLockedUser()
        {
          
            Asserts.assertTrue(lockedUserMessage.Displayed);
        }

        public void CheckLoginForProblemUser()
        {
            Waits.waitFor(1);
            Asserts.assertTrue(problemUserImages.Displayed);
        }

        public void LoginButtonUIsDisplayed()
        {
             Asserts.assertTrue(loginButton.Enabled);
        }
    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowBDDAutomationFramework.Pages;
using SpecFlowBDDAutomationFramework.Utility;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public class FilterFunctionalityOnProductPageStepDefinitions
    {

        private IWebDriver driver;
        private LoginPage loginPage;
        private ProductPage productPage;


        public FilterFunctionalityOnProductPageStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [When(@"User enters credentials for standart_user")]
        public void WhenUserEntersCredentialsForStandart_User()
        {
            loginPage = new LoginPage(driver);
            loginPage.enterCredentials(TestData.standartUser, TestData.password);
        }

        [When(@"Select NameAToZ")]
        public void WhenSelectNameAToZ()
        {
            productPage = new ProductPage(driver);
            productPage.selectFromDropDown("az");
            Waits.waitFor(1);
        }

        [When(@"Verify that products sorted from A to Z")]
        public void WhenVerifyThatProductsSortedFromAToZ()
        {
            IList<IWebElement> productList = driver.FindElements(By.CssSelector("[class='inventory_list']"));

            var alphabetical = true;
            for (int i = 0; i < productList.Count - 1; i++)
            {
                if (StringComparer.Ordinal.Compare(productList[i], productList[i + 1]) > 0)
                {
                    alphabetical = false;
                    break;
                }
            }
            Assert.True(alphabetical);
        }

        [When(@"Select NameZToZ")]
        public void WhenSelectNameZToZ()
        {
            productPage.selectFromDropDown("za");
            Waits.waitFor(1);
        }

        [When(@"Verify that products sorted from Z to A")]
        public void WhenVerifyThatProductsSortedFromZToA()
        {
            IList<IWebElement> productList = driver.FindElements(By.CssSelector("[class='inventory_list']"));
            var alphabetical = true;
            for (int i = 0; i < productList.Count - 1; i++)
            {
                if (StringComparer.Ordinal.Compare(productList[i], productList[i + 1]) < 0)
                {
                    alphabetical = false;
                    break;
                }
            }
            Assert.True(alphabetical);
        }

        [When(@"Select LowToHigh")]
        public void WhenSelectLowToHigh()
        {
            productPage.selectFromDropDown("lohi");
            Waits.waitFor(1);
        }

        [When(@"Verify that products sorted from low to high")]
        public void WhenVerifyThatProductsSortedFromLowToHigh()
        {
            IList<IWebElement> priceList = driver.FindElements(By.CssSelector("[class='inventory_item_price']"));
            List<string> priceListStr = new List<string>();
            List<double> priceListDouble = new List<double>();
            for (int i = 0; i < priceList.Count; i++)
            {
                priceListStr.Add(priceList[i].Text.ToString().Substring((priceList[i].Text.ToString().IndexOf("$") + 1), (priceList[i].Text.ToString().Length - 1)));
                Console.WriteLine(priceListStr[i]);
            }
            for (int i = 0; i < priceListStr.Count; i++)
            {
                priceListDouble.Add(Double.Parse(priceListStr[i]));
                Console.WriteLine(priceListDouble[i]);
            }
            var pricefilter = true;

            for (int i = 0; i < priceListDouble.Count - 1; i++)
            {
                if (priceListDouble[i] > priceListDouble[i + 1])
                {
                    pricefilter = false; break;
                }

            }
            Assert.True(pricefilter);
        }

        [When(@"Select HighToLow")]
        public void WhenSelectHighToLow()
        {
            productPage.selectFromDropDown("hilo");
            Waits.waitFor(1);
        }

        [Then(@"Verify that products sorted from high to low")]
        public void ThenVerifyThatProductsSortedFromHighToLow()
        {
            IList<IWebElement> priceList = driver.FindElements(By.CssSelector("[class='inventory_item_price']"));

            List<string> priceListStr = new List<string>();
            List<double> priceListDouble = new List<double>();
            for (int i = 0; i < priceList.Count; i++)
            {
                priceListStr.Add(priceList[i].Text.ToString().Substring((priceList[i].Text.ToString().IndexOf("$") + 1), (priceList[i].Text.ToString().Length) - 1));
            }
            for (int i = 0; i < priceListStr.Count; i++)
            {
                priceListDouble.Add(Double.Parse(priceListStr[i]));
            }
            var pricefilter = true;

            for (int i = 0; i < priceListDouble.Count - 1; i++)
            {
                if (priceListDouble[i] < priceListDouble[i + 1])
                {
                    pricefilter = false; break;
                }

            }
            Assert.True(pricefilter);
        }
    }
}

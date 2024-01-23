using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ST_Project.SauceDemo.YourCart
{
    internal class YourCart : CorePage
    {
        #region locators

        By continueshoppbtn = By.Id("continue-shopping");
        By saucelabonesietshirt = By.Id("add-to-cart-sauce-labs-onesie");
        By saucelabshopcartbtn = By.ClassName("shopping_cart_link");
        By checkoutbtn = By.Id("checkout");

        #endregion


        public void Cart()
        {
            Actions actions = new Actions(driver);
            for (int i = 0; i < 6; i++)
            {
                actions.SendKeys(Keys.ArrowDown);
            }
            actions.Build().Perform();

            Thread.Sleep(2000);

            driver.FindElement(continueshoppbtn).Click();

            Thread.Sleep(2000);

            driver.FindElement(saucelabonesietshirt).Click();

            Thread.Sleep(1000);

            for (int i = 0; i < 12; i++)
            {
                actions.SendKeys(Keys.ArrowUp);
            }
            actions.Build().Perform();

            driver.FindElement(saucelabshopcartbtn).Click();

            for (int i = 0; i < 15; i++)
            {
                actions.SendKeys(Keys.ArrowDown);
            }
            actions.Build().Perform();

            IWebElement button = driver.FindElement(checkoutbtn);
            Thread.Sleep(3000);

            button.Click();



        }
    }
}

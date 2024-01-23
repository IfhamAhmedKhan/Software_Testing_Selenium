using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ST_Project.SauceDemo.ProductPage
{
    internal class ProductPage : CorePage
    {
        #region locators

        By saucelabbagpack = By.Id("add-to-cart-sauce-labs-backpack");
        By saucelabboltshirt = By.Id("add-to-cart-sauce-labs-bolt-t-shirt");
        By saucelabredtsshirt = By.Id("add-to-cart-test.allthethings()-t-shirt-(red)");
        By saucelabshopcartbtn = By.ClassName("shopping_cart_link");

        #endregion

        public void products()
        {
            Actions actions = new Actions(driver);
            Thread.Sleep(1000);

            driver.FindElement(saucelabbagpack).Click();
            Thread.Sleep(1000);


            for (int i = 0; i < 8; i++)
            {
                actions.SendKeys(Keys.ArrowDown);
            }
            actions.Build().Perform();

            Thread.Sleep(1000);

            driver.FindElement(saucelabboltshirt).Click();

            Thread.Sleep(1000);

            driver.FindElement(saucelabredtsshirt).Click();

            Thread.Sleep(1000);

            for (int i = 0; i < 8; i++)
            {
                actions.SendKeys(Keys.ArrowUp);
            }
            actions.Build().Perform();

            Thread.Sleep(2000);

            driver.FindElement(saucelabshopcartbtn).Click();

            Thread.Sleep(2000);

            for (int i = 0; i < 6; i++)
            {
                actions.SendKeys(Keys.ArrowDown);
            }
            actions.Build().Perform();

            Thread.Sleep(2000);
        }
    }
}

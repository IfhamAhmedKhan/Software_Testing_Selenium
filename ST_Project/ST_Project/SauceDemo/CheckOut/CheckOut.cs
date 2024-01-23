using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ST_Project.SauceDemo.CheckOut
{
    internal class CheckOut : CorePage
    {
        #region locators

        By firstnametxt = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/input[1]");
        By lastnametxt = By.XPath("//input[@name='lastName']");
        By zipcodetxt = By.XPath("//input[@name='postalCode']");
        By continuebtn = By.XPath("//input[@id='continue']");
        By finishbtn = By.XPath("//button[@class='btn btn_action btn_medium cart_button']");
        By openmenubtn = By.XPath("//button[@id='react-burger-menu-btn']");
        By logoutBtn = By.XPath("//a[@id='logout_sidebar_link' and text()='Logout']");
        #endregion

        public void checkOut()
        {

            driver.FindElement(firstnametxt).SendKeys("Ifham");
            driver.FindElement(lastnametxt).SendKeys("Khan");
            driver.FindElement(zipcodetxt).SendKeys("05444");
            driver.FindElement(continuebtn).Click();
            Thread.Sleep(3000);

            Actions actions = new Actions(driver);
            for (int i = 0; i < 12; i++)
            {
                actions.SendKeys(Keys.ArrowDown);
            }
            actions.Build().Perform();
            Thread.Sleep(2000);

            driver.FindElement(finishbtn).Click();
            Thread.Sleep(2000);

            for (int i = 0; i < 8; i++)
            {
                actions.SendKeys(Keys.ArrowUp);
            }
            actions.Build().Perform();

            Thread.Sleep(2000);

            driver.FindElement(openmenubtn).Click();

            Thread.Sleep(2000);

            driver.FindElement(logoutBtn).Click();
            Thread.Sleep(2000);

        }

        public void checkOut2()
        {

            driver.FindElement(firstnametxt).SendKeys("Ifham");
            driver.FindElement(lastnametxt).SendKeys("Khan");
            driver.FindElement(continuebtn).Click();
            Thread.Sleep(1000);


        }
    }
}

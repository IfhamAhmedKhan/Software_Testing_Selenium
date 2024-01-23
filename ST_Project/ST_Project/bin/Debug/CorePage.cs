using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{
    internal class CorePage
    {
        public static IWebDriver driver;


        public static void SeleniumInit(string browser)
        {
            if (browser == "Chrome")
            {
                var ChromeOptions = new ChromeOptions();
                ChromeOptions.AddArguments("--start-maximized");
                ChromeOptions.AddArguments("--incognito");
                driver = new ChromeDriver(ChromeOptions);


            }
            else if (browser == "FireFox")
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddArguments("--start-maximized");
                options.AddArguments("--incognito");

                driver = new FirefoxDriver(options);

            }
        }
    }
}

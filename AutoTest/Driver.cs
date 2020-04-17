

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutoTest
{
    public static class Driver
    {
        public static IWebDriver driver = new ChromeDriver();

        public static void WaitForElementUpTo(int seconds = 5)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }
    }


}

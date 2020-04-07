using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace CheckBox
{
    class CheckBoxProgram
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement checkbox;
        static void Main()
        {
            string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";
            string option = "1"; //1 and 3

            driver.Navigate().GoToUrl(url);

            ///////Test1
            checkbox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child("+ option +")"));
            if (checkbox.GetAttribute("checked") == "true") Console.WriteLine("It was checked");
            else Console.WriteLine("It wasNOT checked");

            /////////Test2
            Console.WriteLine(checkbox.GetAttribute("value"));
            option = "3";
            checkbox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + option + ")"));
            Console.WriteLine(checkbox.GetAttribute("value"));

            ////////Test3
            option = "1";
            checkbox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + option + ")"));
            checkbox.Click();
            Thread.Sleep(2500);


            driver.Quit();

        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AlertBox
{
    class AlertBoxProgram
    {
        static IWebDriver driver = new ChromeDriver();
        static IAlert alert;
        static IWebElement image;
        static void Main()
        {
            string url = "http://testing.todvachev.com/special-elements/alert-box/";
            driver.Navigate().GoToUrl(url);

            alert = driver.SwitchTo().Alert();
            

            alert.Accept();

            image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));

            try
            {
                if (image.Displayed) Console.WriteLine("The Image is there");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Something was wrong");
            }

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}

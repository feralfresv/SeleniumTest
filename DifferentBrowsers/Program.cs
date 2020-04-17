using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace DifferentBrowsers
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new InternetExplorerDriver();

            System.Console.WriteLine(driver.GetType().ToString());

            if (driver.GetType().ToString().Contains("InternetExplorer"))
                driver.Navigate().GoToUrl("https://www.hotmail.com/");
            else if(driver.GetType().ToString().Contains("Chrome"))
                driver.Navigate().GoToUrl("https://www.gmail.com/");


        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace CSSandXPath
{
    class CSSnXPathProgram
    {
        static void Main()
        {
            string url = "http://testing.todvachev.com/selectors/css-path/";
            string cssPath = "#post-108 > div > figure > img"; //Copy selector
            string xPath = "//*[@id=\"post-108\"]/div/figure/img"; //Copy Xpath //Add "\"

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);

            IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
            IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

            if(cssPathElement.Displayed) GreenMessage("Yes I can see it");
            else RedMessage("No, Ist not there");
            if (xPathElement.Displayed) GreenMessage("Yes I can see it");
            else RedMessage("No, Ist not there");

            driver.Quit();


        }

        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

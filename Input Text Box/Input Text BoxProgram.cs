using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Input_Text_Box
{
    class Program
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement textbox;
        static void Main()
        {
            string url = "http://testing.todvachev.com/special-elements/text-input-field/";

            driver.Navigate().GoToUrl(url);

            textbox = driver.FindElement(By.Name("username")); 
            textbox.SendKeys("Text texHalamadrid");
            Thread.Sleep(3000);
            Console.WriteLine(textbox.GetAttribute("value"));
            Console.WriteLine(textbox.GetAttribute("maxlength"));
            Thread.Sleep(2000);



            driver.Quit();
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DropDownManu
{
    class DropDownManuProgram
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement dropDownMenu;
        static IWebElement elementFromTheDropDOwnMenu;
        static void Main()
        {
            string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
            string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(1)";
            driver.Navigate().GoToUrl(url);


            dropDownMenu = driver.FindElement(By.Name("DropDownTest")); 
            Console.WriteLine(dropDownMenu.GetAttribute("value"));

            driver.Quit();
        }
    }
}

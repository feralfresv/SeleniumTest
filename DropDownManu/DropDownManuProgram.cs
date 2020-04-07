using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

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
            string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";
            driver.Navigate().GoToUrl(url);


            dropDownMenu = driver.FindElement(By.Name("DropDownTest")); 
            Console.WriteLine( "The selected value is" + dropDownMenu.GetAttribute("value"));

            elementFromTheDropDOwnMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));
            Console.WriteLine("The third value is " + elementFromTheDropDOwnMenu.GetAttribute("value"));

            elementFromTheDropDOwnMenu.Click();
            Console.WriteLine("The select value is: "+ dropDownMenu.GetAttribute("value"));

            Thread.Sleep(3000);

            for (int i = 1; i <= 4; i++)
            {
                dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child("+ i +")";
                elementFromTheDropDOwnMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

                Console.WriteLine("The "+ i +" value is " + elementFromTheDropDOwnMenu.GetAttribute("value"));
            }

            Thread.Sleep(5000);

            driver.Quit();
        }
    }
}

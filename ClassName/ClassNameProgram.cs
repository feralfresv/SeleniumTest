using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ClassName
{
    class ClassNameProgram
    {
        static void Main()
        {
            string url = "http://testing.todvachev.com/selectors/class-name/";
            string className = "testClass";

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);


            IWebElement element = driver.FindElement(By.ClassName(className));
            Console.WriteLine(element.Text);

            driver.Quit();

        }
    }
}

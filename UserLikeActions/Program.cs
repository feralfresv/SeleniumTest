using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace UserLikeActions
{
    class Program
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            string url = "http://testing.todvachev.com/draganddrop/draganddrop.html";

            driver.Navigate().GoToUrl(url);
            string[] elementsId =
            {
                "Drag1",
                "Drag2",
                "Drag3",
                "Drag4",
                "Drag5"
            };

            IWebElement[] elements =
            {
                driver.FindElement(By.Id(elementsId[0])),
                driver.FindElement(By.Id(elementsId[1])),
                driver.FindElement(By.Id(elementsId[2])),
                driver.FindElement(By.Id(elementsId[3])),
                driver.FindElement(By.Id(elementsId[4]))
        };

            Actions actions = new Actions(driver);


            //string lightGrenn = "rgba(144, 238, 144, 1)";
            //actions.MoveToElement(elements[0]).Build().Perform();
            //Console.WriteLine(elements[0].GetCssValue("background-color") == lightGrenn);
            //Console.WriteLine(elements[1].GetCssValue("background-color") == lightGrenn);

            MoveElement(actions, elements[0], elements[1], 0, 10);
            MoveElement(actions, elements[0], elements[2], 0, 10);
            MoveElement(actions, elements[0], elements[3], 0, 10);
            MoveElement(actions, elements[1], elements[3], 0, 10);
        }

        static void MoveElement(Actions actions, IWebElement from, IWebElement to, int x = 0, int y = 0)
        {
            actions.ClickAndHold(from)
                   .MoveToElement(to)
                   .MoveByOffset(x, y)
                   .Release().Build().Perform();           
        }


    }
}

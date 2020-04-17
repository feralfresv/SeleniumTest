using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;

namespace SizeAndPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Size size = new Size();
            size.Width = 300;
            size.Height = 300;

            Point position = new Point();
            position.X = 400;
            position.Y = 250;

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Size = size;
            driver.Manage().Window.Position = position;

            driver.Navigate().GoToUrl("http://testing.todvachev.com");


        }
    }
}

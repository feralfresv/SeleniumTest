using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
//http://testing.todvachev.com/

namespace SeleniumTest
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
        IWebElement textBox;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string url = "http://testing.todvachev.com/special-elements/text-input-field/";
            driver.Navigate().GoToUrl(url);


            textBox = driver.FindElement(By.Name("username"));
            textBox.SendKeys("Test text");
            Thread.Sleep(3000);
            Console.WriteLine(textBox.GetAttribute("value"));
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
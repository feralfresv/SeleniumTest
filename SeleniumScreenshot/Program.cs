using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace SeleniumScreenshot
{
    class Program
    {
        static void Main()
        {
            IWebDriver chrome = new ChromeDriver();

            string screenshotsDirectory = Directory.GetCurrentDirectory() + @"\screenshots";

            chrome.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Test_case");

            Screenshot googleScrennshot = ((ITakesScreenshot)chrome).GetScreenshot();

            if (Directory.Exists(screenshotsDirectory))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshots");
            }
           
            googleScrennshot.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshots\googlescreenshots.png", ScreenshotImageFormat.Png);

            chrome.Quit();
        }
    }
}

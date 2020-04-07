using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class NameSelectorProgram
{
    static void Main()
    {
        IWebDriver drive = new ChromeDriver();

        drive.Navigate().GoToUrl("http://testing.todvachev.com/selectors/name/");

        IWebElement element = drive.FindElement(By.Name("myName"));

        if (element.Displayed)
        {
            GreenMessage("Yes I can see de element");
        }
        else
        {
            RedMessage("Well, something went wrong, I could see the element");
        }

        //Request-> This is a paragraph with text that belongs to a class.
        drive.Quit();
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


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace LoginForm
{
//Username field with less than 5 characters and correct password(invalid login)
//Username field with more than 12 characters and correct password(invalid login)
//Username field with 5-12 characters and incorrect password(invalid login)
//Username field with correct login credentials(valid login)
    class LoginFormProgram
    {
        static readonly IWebDriver driver = new ChromeDriver();
        static IWebElement textboxUsername, textboxPassword, textboxRepeatPaswword, buttonClick;
        static IAlert alert;

        static void Main()
        {
            string url = "http://testing.todvachev.com/test-scenarios/login-form/?userid=refrefref&passid=refrefref&repeatpassid=refrefref&submit=LOGIN";
            driver.Navigate().GoToUrl(url);

            textboxUsername = driver.FindElement(By.Name("userid"));
            textboxUsername.SendKeys("less");

            textboxPassword = driver.FindElement(By.Name("passid"));
            textboxPassword.SendKeys("correct");

            textboxRepeatPaswword = driver.FindElement(By.Name("repeatpassid"));
            textboxRepeatPaswword.SendKeys("correct");

            buttonClick = driver.FindElement(By.Name("submit"));
            buttonClick.Click();

            alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);

            if (alert.Text == "User Id should not be empty / length be between 5 to 12") RedMessage("No entro lenght");
            else GreenMessage("ERRRRORRR");
            alert.Accept();

            ////
            textboxUsername.Clear();
            textboxUsername.SendKeys("Morethan12numbersonthistextbox");

            buttonClick.Click();
            Console.WriteLine(alert.Text);

            if (alert.Text == "User Id should not be empty / length be between 5 to 12") RedMessage("No entro lenght");
            else GreenMessage("ERRRRORRR");
            alert.Accept();

            ////
            textboxUsername.Clear();
            textboxUsername.SendKeys("UserTest");

            textboxPassword.Clear();
            textboxPassword.SendKeys("Incorrect");

            textboxRepeatPaswword.Clear();
            textboxRepeatPaswword.SendKeys("Correct");

            buttonClick.Click();
            Console.WriteLine(alert.Text);

            if (alert.Text == "Passwords do not match!") RedMessage("No entro password");
            else GreenMessage("ERRRRORRR");
            alert.Accept();

            ///

            textboxPassword.Clear();
            textboxPassword.SendKeys("Correct");

            buttonClick.Click();
            Console.WriteLine(alert.Text);

            if (alert.Text == "Passwords do not match!") RedMessage("No entro password");
            else if (alert.Text == "User Id should not be empty / length be between 5 to 12") RedMessage("No entro lenght");
            else GreenMessage("LOGIN");
            alert.Accept();











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

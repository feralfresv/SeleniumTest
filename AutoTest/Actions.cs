
using AutoTest.UIElements;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AutoTest
{
    public static class Actions
    {
        public static void InitializerDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }

        public static void FillLoginForm(string username, string password, string repeatpassword)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost();

            lsPost.Username.Clear();
            lsPost.Username.SendKeys(username);
            lsPost.Password.Clear();
            lsPost.Password.SendKeys(password);
            lsPost.RepeatPassword.Clear();
            lsPost.RepeatPassword.SendKeys(repeatpassword);
            Thread.Sleep(2000);
            lsPost.ButtonClick.Click();
        }
    }
}

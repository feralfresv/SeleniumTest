
using AutoTest.UIElements;
using System.Threading;

namespace AutoTest
{
    public class Actions
    {
        public static void InitializerDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);
        }

        public static void FillLoginForm(string username, string password, string repeatpassword)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost();

            lsPost.Username.SendKeys(username);
            lsPost.Password.SendKeys(password);
            lsPost.RepeatPassword.SendKeys(repeatpassword);
            Thread.Sleep(2000);
            lsPost.ButtonClick.Click();
        }
    }
}

using AutoTest.UIElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTest
{
    public class Actions
    {
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

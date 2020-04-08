using AutoTest.UIElements;
using System.Threading;

namespace AutoTest
{
    public class EntryPoint
    {
        static void Main()
        {
            
            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");
            NavigateTo.LoginFormThroughtTheMenu();
            Thread.Sleep(1000);

            //Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");
            //NavigateTo.LoginFormThroughtThePost();
            //Thread.Sleep(5000);
            //Driver.driver.Quit();

            Actions.FillLoginForm(Config.Credentials.Valid.UserName, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);


            
        }

    }
}

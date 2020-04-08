
using AutoTest.UIElements;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace AutoTest
{
    public static class NavigateTo
    {
        public static void LoginFormThroughtTheMenu()
        {
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            Thread.Sleep(500);
            tsPage.LoginForm.Click();
            Thread.Sleep(500);

        }

        public static void LoginFormThroughtThePost()
        {
            Menu menu = new Menu();
            TestCasesPage tsPage = new TestCasesPage();
            UsernameFieldPost ufPost = new UsernameFieldPost();

            menu.TestCases.Click();
            Thread.Sleep(500);
            tsPage.LoginForm.Click();

            Thread.Sleep(500);
            ufPost.LoginFormLink.Click();
            Thread.Sleep(500);


        }


    }
}

using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoTest.Scenarios
{
    public class LoginInvalidPassword
    {
        IAlert alert;

        public LoginInvalidPassword()
        {

        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializerDriver();
            NavigateTo.LoginFormThroughtThePost();
        }

        [TestCase]
        public void lessThan5Char()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.UserName, Config.Credentials.Invalid.Password.FourCharacters , Config.Credentials.Invalid.Password.FourCharacters);
            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLenghtOutOfRange, alert.Text);

            alert.Accept();

        }

        [TestCase]
        public void lessThan12Char()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.UserName, Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters);
            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLenghtOutOfRange, alert.Text);

            alert.Accept();

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}

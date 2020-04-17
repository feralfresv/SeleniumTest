using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoTest.Scenarios
{
    public class LoginInvalidUsername
    {
        IAlert alert;

        public LoginInvalidUsername()
        {

        }

        [SetUp]
        public void Initialize()
        {
            Actions.InitializerDriver();
            NavigateTo.LoginFormThroughtThePost();
        }

        [Test]
        public void LessThan5Char()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.UserName.FourCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutOfRange, alert.Text);

            alert.Accept();
        }

        [Test]
        public void MoreThan12Char()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.UserName.ThirteenCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutOfRange, alert.Text);
            
            alert.Accept();
        }




        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AutoTest
{
    public class EntryPoint
    {
        public static void Main()
        {

        }

        #region Primer Ejemplo de Run Test
        //[SetUp]
        //public void Initialize() {Actions.InitializerDriver();}       
        //[Test] 
        //public void ValidLogin()
        //{
        //    NavigateTo.LoginFormThroughtTheMenu();
        //    Actions.FillLoginForm(Config.Credentials.Valid.UserName, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);
        //    alert = Driver.driver.SwitchTo().Alert();
        //    Assert.AreEqual(Config.AlertMessages.SucceddfullLogin, alert.Text);
        //    alert.Accept();
        //}
        //[TearDown]
        //public void CleanUp() {Driver.driver.Quit();}
        #endregion
    }
}

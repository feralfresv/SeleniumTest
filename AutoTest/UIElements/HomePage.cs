﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTest.UIElements
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }  

        [FindsBy(How = How.CssSelector, Using = "#page-17 > header > h1")]
        public IWebElement Headline { get; set; } 

    }
}

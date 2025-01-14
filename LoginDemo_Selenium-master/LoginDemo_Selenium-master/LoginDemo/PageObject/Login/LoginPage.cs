﻿using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Text;

namespace LoginDemo.PageObject.Login
{
    [TestFixture]
    public class LoginPage : BasePage
    {
        // Constructor
        public LoginPage(string url, IWebDriver driver) : base(url, driver) { }

        // Localizadores
        //private By txtLogin = By.Id("username");
        //private By txtPass = By.Id("password");
        //private By btnLogin = By.CssSelector("#login > button");
        //private By msjAlert = By.Id("flash");

        private By txtLogin = By.XPath("//input[@name='mail']");
        private By txtPass = By.XPath("//input[@name='password']");
        private By btnLogin = By.XPath("//button[@type='submit']");
        private By msjAlert = By.Id("flash");


        

        // Set
        public IWebElement set_txtUser() { return _webDriver.FindElement(this.txtLogin); }
        public IWebElement set_txtPass() { return _webDriver.FindElement(this.txtPass); }
        public IWebElement set_btnLogin() { return _webDriver.FindElement(this.btnLogin); }
        public IWebElement set_msjAlert() { return _webDriver.FindElement(this.msjAlert); }

        // Metodos
        public void enterCredentials(string user, string pass)
        {
            set_txtUser().SendKeys(user);
            set_txtPass().SendKeys(pass);
        }

        public void clickButtom()
        {
            set_btnLogin().Click();
        }
    }

}

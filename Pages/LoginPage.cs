using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TurnupPortalPageObjectModel_Meth.Pages
{
    public class LoginPage
    {
        //Fuctions that allow users to login to Turnup portal
        public void LoginActions(IWebDriver driver) 
        {
            //Launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            //identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            //identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //identify login button and click on
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);

        }
    }
}

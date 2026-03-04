using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TurnupPortalPageObjectModel_Meth.Pages;
using TurnupPortalPageObjectModel_Meth.Utilities;
using static System.Net.Mime.MediaTypeNames;

namespace TurnupPortalPageObjectModel_Meth.Tests
{
    public  class TM_Tests : CommonDriver
    {

        [SetUp]
        public void SetUpSteps() 
        {
            //open the browser
            driver = new ChromeDriver();

            // Open Chrome Browser
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
            driver = new ChromeDriver(options);

            //Implicit Wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //Login page object initialization and definition
            LoginPage loginPage = new LoginPage();
            loginPage.LoginActions(driver);

            //Home page object initialization and definition
            HomePage homePage = new HomePage();
            homePage.NavigateTMPage(driver);

            homePage.LoginVerification(driver);
        }
        [Test]
        public void CreateTime_Test()

        {
            TMPage tMPage = new TMPage();
            tMPage.CreateTimeRecord(driver);
        }
        [Test]
        public void EditTime_Test()
        {
            TMPage tMPage = new TMPage();
            tMPage.EditTimeRecord(driver);
        }
        [Test]
        public void DeleteTime_Test()
        {
            TMPage tMPage = new TMPage();
            tMPage.DeleteTimeRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {

        }

    }
}

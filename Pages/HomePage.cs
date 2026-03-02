using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TurnupPortalPageObjectModel_Meth.Utilities;

namespace TurnupPortalPageObjectModel_Meth.Pages
{
    public class HomePage

    {

        public void NavigateTMPage(IWebDriver driver)
        {

            //navigate to Administration Page to select the time and Material from the drop down
            IWebElement adminPage = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminPage.Click();
            
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a",10);

            //select the time and Material from the drop down
            IWebElement timeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterial.Click();
        }

        public void LoginVerification(IWebDriver driver)
        {
            //check if user has logged in successfully
            IWebElement hellometh = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            if (hellometh.Text == "Hello hari!")
            {
                Console.WriteLine("User logged successfully. Test Passed !!");
            }
            else
            {
                Console.WriteLine("User has not logged in. Test Failed !!");
            }
        }


    }
}



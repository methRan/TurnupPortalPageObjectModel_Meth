using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TurnupPortalPageObjectModel_Meth.Utilities
{
    public class Wait
    {
        //Generic function to wait for an element to be clickable
        public static void WaitToBeClickable(IWebDriver driver, string locaterType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0,0,seconds));

            if (locaterType == "XPath")
            { 
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locaterType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }

        }

        public static void WaitToBeVisible(IWebDriver driver, string locaterType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locaterType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locaterType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }

        }
    }
}

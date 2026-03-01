using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TurnupPortalPageObjectModel_Meth.Pages
{
    public class TMPage
    {

        public void CreateTimeRecord(IWebDriver driver) 
        {
            //click on create new button
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNew.Click();
            Thread.Sleep(1000);

            //select time from the dropdown
            IWebElement typeCodedropDown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodedropDown.Click();

            IWebElement timeButton = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeButton.Click();

            //type the code into Code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("TA Program");

            //type the description into Description textbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("This is fun");

            //type the price per unit into Price textbox
            IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTagOverlap.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("23");

            //select files

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            //check if time material created successfully
            IWebElement goToLastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastpageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "TA Program")
            {
                Console.WriteLine("Time record created successfully");
            }
            else
            {
                Console.WriteLine("New time has not been created");
            }

        }

        public void EditTimeRecord(IWebDriver driver)
        { 
         //edit time record
        }

        public void DeleteTimeRecord(IWebDriver driver)
        { 
         //delete time record
        }
    }
}

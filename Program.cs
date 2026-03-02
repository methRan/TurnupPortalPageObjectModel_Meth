using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TurnupPortalPageObjectModel_Meth.Pages;

public class Program
{
    public static void Main(string[] args)
    {
        //open the browser
        IWebDriver driver = new ChromeDriver();

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

        //TM Page object initilization and definition
        TMPage tMPage = new TMPage();
        tMPage.CreateTimeRecord(driver);

        tMPage.EditTimeRecord(driver);

        tMPage.DeleteTimeRecord(driver);


    }
}
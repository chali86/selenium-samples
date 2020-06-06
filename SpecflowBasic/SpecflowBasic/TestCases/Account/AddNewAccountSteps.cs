using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using SpecflowBasic.Utilities;
using SpecflowBasic.Pages.AccountPortal;
using SpecflowBasic.Pages.CustomerPortal;

namespace SpecflowBasic.TestCases.Account
{
    [Binding]
    public class AddNewAccountSteps
    {
        private IWebDriver _driver;
        Excel excel = new Excel();

        [Given(@"I am in the guru page")]
        public void GivenIAmInTheGuruPage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(excel.readExcel("\\data.xlsx", 1, 1, 2));

        }

        [Given(@"i logged as the manager")]
        public void GivenILoggedAsTheManager()
        {
            Login login = new Login(_driver);
            login.Logindetails();
        }
        
        [When(@"I navigate to the new account")]
        public void WhenINavigateToTheNewAccount()
        {
            NewAccount newAccount = new NewAccount(_driver);
            newAccount.clickNewAccount();
        }
        
        [Then(@"create new account successfully")]
        public void ThenCreateNewAccountSuccessfully()
        {
            NewAccount newAccount = new NewAccount(_driver);
            newAccount.newAccountDetails();
            newAccount.StoreAccountID();
            _driver.Close();
            _driver.Quit();
        }
    }
}

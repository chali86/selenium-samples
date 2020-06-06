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
    public class DepositMoneySteps
    {
        private IWebDriver _driver;
        Excel excel = new Excel();

        [Given(@"I am in the guru bank page")]
        public void GivenIAmInTheGuruBankPage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(excel.readExcel("\\data.xlsx", 1, 1, 2));
        }

        [Given(@"I logged into manager account")]
        public void GivenILoggedIntoManagerAccount()
        {
            Login login = new Login(_driver);
            login.Logindetails();
        }

        [When(@"I navigate to deposit")]
        public void WhenINavigateToDeposit()
        {
            DepositMoney deposit = new DepositMoney(_driver);
            deposit.clickdeposit();
        }

        [Then(@"i successfully deposit money")]
        public void ThenISuccessfullyDepositMoney()
        {
            DepositMoney deposit = new DepositMoney(_driver);
            deposit.depositdetails();

        }
    }
}

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
    public class WithdrawalMoneySteps
    {
        private IWebDriver _driver;
        Excel excel = new Excel();

        [Given(@"I am in the guru login page")]
        public void GivenIAmInTheGuruLoginPage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(excel.readExcel("\\data.xlsx", 1, 1, 2));
        }

        [Given(@"I logged into manager profile")]
        public void GivenILoggedIntoManagerProfile()
        {
            Login login = new Login(_driver);
            login.Logindetails();
        }

        [When(@"I navigate to withdrawal")]
        public void WhenINavigateToWithdrawal()
        {
            WithdrawalMoney withdrawal = new WithdrawalMoney(_driver);
            withdrawal.clickWithdrawal();


        }

        [Then(@"I successfully withdrawal money")]
        public void ThenISuccessfullyWithdrawalMoney()
        {
            WithdrawalMoney withdrawal = new WithdrawalMoney(_driver);
            withdrawal.withdrawaldetails();
        }
    }
}

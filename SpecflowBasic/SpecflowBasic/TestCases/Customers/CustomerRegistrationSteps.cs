using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowBasic.Utilities;
using SpecflowBasic.Pages.CustomerPortal;


namespace SpecflowBasic.TestCases.Customers
{
    [Binding]
    public class CustomerRegistrationSteps
    {
        private IWebDriver _driver;
        Excel excel = new Excel();

        [Given(@"Im in the guru bank page")]
        public void GivenImInTheGuruBankPage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(excel.readExcel("\\data.xlsx", 1, 1, 2));
        }

        [Given(@"I logged as manager")]
        public void GivenILoggedAsManager()
        {
            Login login = new Login(_driver);
            login.Logindetails();
        }

        [When(@"I navigate to new customer")]
        public void WhenINavigateToNewCustomer()
        {
            AddNewCustomer newCustomer = new AddNewCustomer(_driver);
            newCustomer.clickNewUserREgister();
            newCustomer.newCustomerdetails();
        }

        [Then(@"create a new customer successfully")]
        public void ThenCreateANewCustomerSuccessfully()
        {
            AddNewCustomer newCustomer = new AddNewCustomer(_driver);
            newCustomer.Submit();
            newCustomer.StoreCustomerID();
            _driver.Close();
            _driver.Quit();
        }
    }
}

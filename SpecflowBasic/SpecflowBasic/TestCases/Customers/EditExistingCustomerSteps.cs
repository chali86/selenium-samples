using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowBasic.Utilities;
using SpecflowBasic.Pages.CustomerPortal;


namespace SpecflowBasic.TestCases.Customers
{
    [Binding]
    public class EditExistingCustomerSteps
    {
        private IWebDriver _driver;
        Excel excel = new Excel();

        [Given(@"I am in the guru home page")]
        public void GivenIAmInTheGuruHomePage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(excel.readExcel("\\data.xlsx", 1, 1, 2));
        }

        [Given(@"I logged as a manager")]
        public void GivenILoggedAsAManager()
        {
            Login login = new Login(_driver);
            login.Logindetails();
        }

        [When(@"I navigate to edit customer")]
        public void WhenINavigateToEditCustomer()
        {
            EditCustomer editCustomer = new EditCustomer(_driver);
            editCustomer.clickNewUserEdit();
            SearchCustomer searchCustomer = new SearchCustomer(_driver);
            searchCustomer.SearchCustomerDetails();

        }

        [Then(@"I edit customer successfully")]
        public void ThenIEditCustomerSuccessfully()
        {
            EditCustomer editCustomer = new EditCustomer(_driver);
            editCustomer.editCustomerdetails();
            editCustomer.Submit();
        }
    }
}
